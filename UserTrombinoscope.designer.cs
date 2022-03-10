namespace WFA_GenerateurTrombinoscope
{
    partial class UserTrombinoscope
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageListPhotosApp = new System.Windows.Forms.ImageList(this.components);
            this.imageListPhotosHtml = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.buttonFichiersPhotos = new System.Windows.Forms.Button();
            this.buttonImporterPhotos = new System.Windows.Forms.Button();
            this.buttonToutSelectionner = new System.Windows.Forms.Button();
            this.buttonOrdonner = new System.Windows.Forms.Button();
            this.buttonExporterHtml = new System.Windows.Forms.Button();
            this.buttonEffacerItem = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowDrop = true;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LabelEdit = true;
            this.listView1.LargeImageList = this.imageListPhotosApp;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(547, 376);
            this.listView1.SmallImageList = this.imageListPhotosHtml;
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.listView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView1_DragDrop);
            this.listView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView1_DragEnter);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // imageListPhotosApp
            // 
            this.imageListPhotosApp.ColorDepth = System.Windows.Forms.ColorDepth.Depth16Bit;
            this.imageListPhotosApp.ImageSize = new System.Drawing.Size(77, 99);
            this.imageListPhotosApp.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageListPhotosHtml
            // 
            this.imageListPhotosHtml.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageListPhotosHtml.ImageSize = new System.Drawing.Size(196, 252);
            this.imageListPhotosHtml.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTitre);
            this.splitContainer1.Panel1.Controls.Add(this.buttonFichiersPhotos);
            this.splitContainer1.Panel1.Controls.Add(this.buttonImporterPhotos);
            this.splitContainer1.Panel1.Controls.Add(this.buttonToutSelectionner);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOrdonner);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExporterHtml);
            this.splitContainer1.Panel1.Controls.Add(this.buttonEffacerItem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(547, 428);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label1.Size = new System.Drawing.Size(37, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "Titre";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBoxTitre.Location = new System.Drawing.Point(0, 26);
            this.textBoxTitre.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(199, 22);
            this.textBoxTitre.TabIndex = 10;
            // 
            // buttonFichiersPhotos
            // 
            this.buttonFichiersPhotos.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFichiersPhotos.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonFichiersPhotos.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.file_import_outline_36;
            this.buttonFichiersPhotos.Location = new System.Drawing.Point(199, 0);
            this.buttonFichiersPhotos.Name = "buttonFichiersPhotos";
            this.buttonFichiersPhotos.Size = new System.Drawing.Size(58, 48);
            this.buttonFichiersPhotos.TabIndex = 0;
            this.toolTip1.SetToolTip(this.buttonFichiersPhotos, "Importer des photos");
            this.buttonFichiersPhotos.UseVisualStyleBackColor = false;
            this.buttonFichiersPhotos.Click += new System.EventHandler(this.buttonImporterFichiersPhotos_Click);
            // 
            // buttonImporterPhotos
            // 
            this.buttonImporterPhotos.BackColor = System.Drawing.SystemColors.Window;
            this.buttonImporterPhotos.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonImporterPhotos.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.folder_arrow_down_36;
            this.buttonImporterPhotos.Location = new System.Drawing.Point(257, 0);
            this.buttonImporterPhotos.Name = "buttonImporterPhotos";
            this.buttonImporterPhotos.Size = new System.Drawing.Size(58, 48);
            this.buttonImporterPhotos.TabIndex = 4;
            this.toolTip1.SetToolTip(this.buttonImporterPhotos, "Importer un dossier photos");
            this.buttonImporterPhotos.UseVisualStyleBackColor = false;
            this.buttonImporterPhotos.Click += new System.EventHandler(this.buttonImporterDossierPhotos_Click);
            // 
            // buttonToutSelectionner
            // 
            this.buttonToutSelectionner.BackColor = System.Drawing.SystemColors.Window;
            this.buttonToutSelectionner.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonToutSelectionner.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.account_question_outline_36;
            this.buttonToutSelectionner.Location = new System.Drawing.Point(315, 0);
            this.buttonToutSelectionner.Name = "buttonToutSelectionner";
            this.buttonToutSelectionner.Size = new System.Drawing.Size(58, 48);
            this.buttonToutSelectionner.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonToutSelectionner, "Ajouter un portrait anonyme");
            this.buttonToutSelectionner.UseVisualStyleBackColor = false;
            this.buttonToutSelectionner.Click += new System.EventHandler(this.buttonImporterPhotoAnonyme_Click);
            // 
            // buttonOrdonner
            // 
            this.buttonOrdonner.BackColor = System.Drawing.SystemColors.Window;
            this.buttonOrdonner.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonOrdonner.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.sort_alphabetical_ascending_36;
            this.buttonOrdonner.Location = new System.Drawing.Point(373, 0);
            this.buttonOrdonner.Name = "buttonOrdonner";
            this.buttonOrdonner.Size = new System.Drawing.Size(58, 48);
            this.buttonOrdonner.TabIndex = 11;
            this.toolTip1.SetToolTip(this.buttonOrdonner, "Effacer la sélection");
            this.buttonOrdonner.UseVisualStyleBackColor = false;
            this.buttonOrdonner.Click += new System.EventHandler(this.buttonOrdonnerAZ_Click);
            // 
            // buttonExporterHtml
            // 
            this.buttonExporterHtml.BackColor = System.Drawing.SystemColors.Window;
            this.buttonExporterHtml.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonExporterHtml.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.office_building_cog_outline_36;
            this.buttonExporterHtml.Location = new System.Drawing.Point(431, 0);
            this.buttonExporterHtml.Name = "buttonExporterHtml";
            this.buttonExporterHtml.Size = new System.Drawing.Size(58, 48);
            this.buttonExporterHtml.TabIndex = 8;
            this.toolTip1.SetToolTip(this.buttonExporterHtml, "Générer le trombinoscope HTML");
            this.buttonExporterHtml.UseVisualStyleBackColor = false;
            this.buttonExporterHtml.Click += new System.EventHandler(this.buttonExporterHtml_Click);
            // 
            // buttonEffacerItem
            // 
            this.buttonEffacerItem.BackColor = System.Drawing.SystemColors.Window;
            this.buttonEffacerItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonEffacerItem.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.trash_can_outline_36;
            this.buttonEffacerItem.Location = new System.Drawing.Point(489, 0);
            this.buttonEffacerItem.Name = "buttonEffacerItem";
            this.buttonEffacerItem.Size = new System.Drawing.Size(58, 48);
            this.buttonEffacerItem.TabIndex = 1;
            this.toolTip1.SetToolTip(this.buttonEffacerItem, "Effacer la sélection");
            this.buttonEffacerItem.UseVisualStyleBackColor = false;
            this.buttonEffacerItem.Click += new System.EventHandler(this.buttonEffacerItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UserTrombinoscope
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserTrombinoscope";
            this.Size = new System.Drawing.Size(547, 428);
            this.Load += new System.EventHandler(this.UserTrombinoscope_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageListPhotosApp;
        private System.Windows.Forms.ImageList imageListPhotosHtml;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonEffacerItem;
        private System.Windows.Forms.Button buttonToutSelectionner;
        private System.Windows.Forms.Button buttonImporterPhotos;
        private System.Windows.Forms.Button buttonExporterHtml;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button buttonFichiersPhotos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonOrdonner;
        private System.Windows.Forms.TextBox textBoxTitre;
    }
}
