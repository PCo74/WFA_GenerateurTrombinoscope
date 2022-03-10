using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_GenerateurTrombinoscope
{
    public partial class FormMain : Form
    {
        private bool _autorun = false;
        private string _pathDemo; 

        public FormMain()
        {
            InitializeComponent();
            _pathDemo = Application.StartupPath + @"/demo/";
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void userListeNoms1_Load(object sender, EventArgs e)
        {
            if (!_autorun) return;
            userListeNoms1.importerCsv(_pathDemo + @"eleves.csv");
            userListeNoms1.ListBox.SetSelected(2, true);
            userListeNoms1.ListBox.SetSelected(4, true);
            userListeNoms1.ListBox.SetSelected(1, true);
        }

        private void générerLeTrombinoscopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.buttonExporterHtml_Click(sender, e);
        }

        private void importerListeNOMPrénomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userListeNoms1.buttonImporterCSV_Click(sender, e);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void importerDesPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.buttonImporterFichiersPhotos_Click(sender, e);
        }

        private void importerDepuisDossierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.buttonImporterDossierPhotos_Click(sender, e);
        }

        private void userTrombinoscope1_Load(object sender, EventArgs e)
        {
            if (!_autorun) return;
            userTrombinoscope1.Titre = "Classe Y Salle 201";
            userTrombinoscope1.importerPhotos(Toolbox.getFilesFromFolder(_pathDemo + @"plan taille", new[] { "*.jpg", "*.png" }));
            userTrombinoscope1.ajouterTrombineAnonyme();
        }

        private void ordonnerAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.ordonnerAZ();
        }

        private void renommerLesPhotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.renommerPhotosOrigines();
        }

        private void exporterAuFormat35x45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userTrombinoscope1.exporterPhotos35x45();
        }

        private void àProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormAPropos().ShowDialog();
        }
    }
}
