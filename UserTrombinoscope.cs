using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace WFA_GenerateurTrombinoscope
{
    public partial class UserTrombinoscope : UserControl
    {       
        public string Titre
        {
            get { return textBoxTitre.Text; }
            set { textBoxTitre.Text = value; }
        }

        private FormCropPhoto _fcp = new FormCropPhoto();

        public UserTrombinoscope()
        {
            InitializeComponent();
        }

        /// <summary>
        /// gestion renommage «Label» ou rien si «escape»
        /// </summary>
        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label != null) // non <ESC>
            {
                ListViewItem lvi = listView1.Items[e.Item];
                Eleve elv = new Eleve(e.Label);
                e.CancelEdit = true;
                lvi.Text = elv.LabelPhoto;
                lvi.ForeColor = Color.DarkGreen; // indique une modification du libellé
            }
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(ListBox)) != null)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listView1_DragDrop(object sender, DragEventArgs e)
        {
            Point loc = listView1.PointToClient(new Point(e.X, e.Y)); // item destination
            ListViewItem lvi = listView1.GetItemAt(loc.X, loc.Y);
            if (lvi != null)
            {
                ListBox lb = e.Data.GetData(typeof(ListBox)) as ListBox;
                Eleve elv = lb.SelectedItem as Eleve;
                if (lvi.ForeColor != Color.Red) // si déjà modifier !
                {
                    lb.Items.Add(new Eleve(lvi.Text)); // remettre elv dans la liste
                }
                else
                {
                    lvi.ForeColor = Color.DarkGreen;
                }
                lvi.Text = elv.LabelPhoto;
                lb.Items.Remove(elv);
            }
        }

        /// <summary>
        /// ajoute toutes les trombines issues d'un dossier (photo + nom du fichier)
        /// </summary>
        /// <param name="unDossier">le dossier dans lequel rechercher les photos («jpg» et «png»)</param>
        public void ajouterDossierPhotos(string unDossier) 
        {
            string[] photos = Toolbox.getFilesFromFolder(unDossier, new[] { "*.jpg", "*.png" });
            if (photos.Count() > 0) ajouterTrombines(photos);
        }

        #region AJOUT DE TROMBINES (photo & libellé)

        /// <summary>
        /// ajoute une trombine
        /// </summary>
        /// <param name="unFichierImage">le nom du fichier «Image» à ajouter</param>
        public void ajouterTrombine(string unFichierImage)
        {
            string nomPrenom = Path.GetFileNameWithoutExtension(unFichierImage);
            Eleve elv = new Eleve(nomPrenom);
            ListViewItem lvi = new ListViewItem(elv.LabelPhoto);
            Portrait portrait = new Portrait(unFichierImage);
            ajouterTrombine(elv, portrait.Current, unFichierImage);
        }

        /// <summary>
        /// ajoute une trombine
        /// </summary>
        /// <param name="unEleve">l'élève</param>
        /// <param name="uneImage">La photo de l'élève</param>
        /// <param name="unTag">le nom complet du fichier d'origine</param>
        private void ajouterTrombine(Eleve unEleve, Image uneImage, string unTag)
        {
            ListViewItem lvi = new ListViewItem(unEleve.LabelPhoto);
            listView1.SmallImageList.Images.Add(uneImage); // pour HTML
            listView1.LargeImageList.Images.Add(uneImage); // pour APPLICATION
            lvi.ImageIndex = listView1.LargeImageList.Images.Count - 1;
            lvi.Tag = unTag;
            lvi.ForeColor = Color.Red;
            listView1.Items.Add(lvi);
        }

        /// <summary>
        /// ajoute une trombine anonyme (pas de photo disponible !)
        /// </summary>
        public void ajouterTrombineAnonyme()
        {
            Image anonyme = global::WFA_GenerateurTrombinoscope.Properties.Resources.portrait_anonyme_35x45;
            ajouterTrombine(new Eleve("Anonyme"), anonyme, "");
        }

        /// <summary>
        /// ajoute des trombines
        /// </summary>
        /// <param name="desFichiers">liste des fichiers «Image»</param>
        public void ajouterTrombines(string[] desFichiers)
        {
            foreach (string fichier in desFichiers) ajouterTrombine(fichier);
        }

        #endregion

        public void exporterHTML(string unTitre, string unNomFic)
        {
            string gabaritPage = getGabaritHtml("gabarit_trombinoscope.html");
            gabaritPage = gabaritPage.Replace("{titre}", unTitre);

            string gabaritDivTrombine = getGabaritHtml("gabarit_div_trombine.html");
            string divs = Environment.NewLine;
            foreach (ListViewItem lvi in listView1.Items)
            {
                Image photo = listView1.SmallImageList.Images[lvi.ImageIndex]; // /!\ SmallImages = 196x252
                Eleve elv = new Eleve(lvi.Text);
                elv.chargerImage(photo);
                string div = String.Format(gabaritDivTrombine, lvi.ImageIndex, elv.NomComplet, elv.PrenomComplet, elv.Image64, elv.Nom, elv.Prenom);
                divs += div + Environment.NewLine;
            }
            gabaritPage = gabaritPage.Replace("{trombines}", divs);
            File.WriteAllText(unNomFic, gabaritPage, Encoding.UTF8);
            Process.Start(unNomFic);
        }

        private void UserTrombinoscope_Load(object sender, EventArgs e)
        {

        }

        public void buttonImporterDossierPhotos_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.Description = "Importer les photos d'un dossier";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                ajouterDossierPhotos(folderBrowserDialog1.SelectedPath);
            }
        }

        private void buttonEffacerItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listView1.SelectedItems)
            {
                lvi.Remove();
            }
        }

        private void buttonImporterPhotoAnonyme_Click(object sender, EventArgs e)
        {
            ajouterTrombineAnonyme();
        }

        private void selectionnerTout()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                lvi.Selected = true;
            }
            listView1.HideSelection = false;
        }

        /// <summary>
        /// edite la photo pour recadrage
        /// </summary>
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // ouvre la fenêtre de recadrage de la photo           
            ListViewItem lvi = listView1.SelectedItems[0] as ListViewItem;
            _fcp.changeListViewItem(lvi);
            _fcp.Visible = true;
            _fcp.BringToFront();
        }

        public void buttonExporterHtml_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Web HTML|*.html";
            saveFileDialog1.Title = "Sauvegarde le trombinoscope";
            string nomfic = Toolbox.getValidFileName(textBoxTitre.Text);
            saveFileDialog1.FileName = Toolbox.getValidFileName(textBoxTitre.Text); ;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                exporterHTML(textBoxTitre.Text, saveFileDialog1.FileName);
            }
        }

        public void buttonImporterFichiersPhotos_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importer des photos";
            openFileDialog1.Filter = "Fichiers images (*.jpg  *.png) |*.jpg;*.png";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importerPhotos(openFileDialog1.FileNames);
            }
        }

        public void importerPhotos(string[] desFichiers)
        {
            foreach (string fichier in desFichiers)
            {
                Portrait portrait = new Portrait(fichier);
                Eleve elv = new Eleve(Path.GetFileNameWithoutExtension(fichier));
                ajouterTrombine(elv, portrait.Current, fichier);
            }
            ordonnerAZ();
        }



        public void ordonnerAZ()
        {
            listView1.Sort();
        }

        private void buttonOrdonnerAZ_Click(object sender, EventArgs e)
        {
            ordonnerAZ();
        }

        /// <summary>
        /// renomme les photos d'origines
        /// </summary>
        public void renommerPhotosOrigines()
        {
            foreach (ListViewItem lvi in listView1.Items)
            {
                string ficOrigine = lvi.Tag.ToString();
                if (!String.IsNullOrEmpty(ficOrigine))
                {
                    string path = Path.GetDirectoryName(ficOrigine);
                    string ext = Path.GetExtension(ficOrigine);
                    Eleve elv = new Eleve(lvi.Text);
                    string ficNouveau = string.Format("{0}\\{1}{2}", path, elv.NomFichierSansExt, ext);
                    if (ficOrigine != ficNouveau)
                    {
                        System.IO.File.Move(ficOrigine, ficNouveau);
                        lvi.Tag = ficNouveau;
                    }
                }
            }
        }

        /// <summary>
        /// exporte les photos recadrées au format «jpg» (taille = 192x252 pixels)
        /// </summary>
        /// <param name="unNomRep">nom du répertoire où enregistrer les photos</param>
        /// <remarks>suffixe le nom de fichier par «_35x45»</remarks>
        public void exporterPhotos35x45(string unNomRep = null)
        {
            if (String.IsNullOrEmpty(unNomRep))
            {
                folderBrowserDialog1.Description = "Exportation des photos au format 35x45";
                if (folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
                unNomRep = folderBrowserDialog1.SelectedPath;
            }
            foreach (ListViewItem lvi in listView1.Items)
            {
                string nomfic = string.Format(@"{0}\{1}_35x45.jpg", unNomRep, new Eleve(lvi.Text).NomFichierSansExt);
                listView1.SmallImageList.Images[lvi.ImageIndex].Save(nomfic, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        /// <summary>
        /// permet de récupérer les gabarits HTML inclus dans le projet (ressources incorporés)
        /// </summary>
        /// <param name="unFichier">le nom du fichier sans l'espace de nom</param>
        /// <returns>le contenu du fichier sous forme de «string»</returns>
        private string getGabaritHtml(string unFichier)
        {
            string nomComplet = GetType().Namespace + "." + unFichier;
            using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(nomComplet))
            {
                return new StreamReader(stream).ReadToEnd();
            }
        }

    }
}
