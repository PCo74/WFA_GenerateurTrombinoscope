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

namespace WFA_GenerateurTrombinoscope
{
    public partial class UserListeNoms : UserControl
    {
        public ListBox.ObjectCollection Items { get; set; }
        public ListBox ListBox { get; }

        public UserListeNoms()
        {
            InitializeComponent();
            ListBox = listBox1;
            Items = listBox1.Items;
        }

        public void buttonImporterCSV_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Importer une liste d'élèves (1ère colonne = «NOM Prénom»)";
            openFileDialog1.Filter = "Fichiers|*.csv;*.txt| Tous (*.*)|*.*";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                importerCsv(openFileDialog1.FileName);
            }
        }

        public void importerCsv(string unFichierCsv)
        {
            try
            {
                Encoding encoding = Toolbox.getEncoding(unFichierCsv);
                string[] allLines = File.ReadAllLines(unFichierCsv, encoding);
                // REF : https://stackoverflow.com/questions/27965131/how-to-remove-the-first-element-in-an-array
                allLines = allLines.Skip(1).ToArray();
                foreach (string line in allLines)
                {
                    string[] parts = line.Split('"');
                    string nom_prenom = (parts.Length > 1) ? parts[1] : parts[0];
                    listBox1.Items.Add(new Eleve(nom_prenom));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Fichier inexistant !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                listBox1.DoDragDrop(listBox1 as ListBox, DragDropEffects.Move);
            }
        }

        private void buttonRetirer_Click(object sender, EventArgs e)
        {
            retirerItem();
        }

        /// <summary>
        /// retire de la liste les éléments sélectionnés
        /// </summary>
        /// <remarks>si aucune sélection, demande la suppression complet</remarks>
        private void retirerItem()
        {
            if (listBox1.SelectedItem != null)
            {
                while (listBox1.SelectedItems.Count > 0)
                {
                    Eleve elv = listBox1.SelectedItems[0] as Eleve;
                    listBox1.SelectedItems.Remove(elv); // important !!!
                    listBox1.Items.Remove(elv);
                }
            }
            else
            {
                if (MessageBox.Show("Tout effacer ?", "Liste d'élèves", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                }
            }
            
        }

        private void UserListeNoms_Load(object sender, EventArgs e)
        {

        }

    }
}
