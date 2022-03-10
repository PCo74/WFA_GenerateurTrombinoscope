namespace WFA_GenerateurTrombinoscope
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.générerLeTrombinoscopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerListeNOMPrénomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerDesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerDepuisDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exporterAuFormat35x45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renommerLesPhotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.àProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userListeNoms1 = new WFA_GenerateurTrombinoscope.UserListeNoms();
            this.userTrombinoscope1 = new WFA_GenerateurTrombinoscope.UserTrombinoscope();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.userListeNoms1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.userTrombinoscope1);
            this.splitContainer1.Size = new System.Drawing.Size(922, 482);
            this.splitContainer1.SplitterDistance = 307;
            this.splitContainer1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.photoToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip2";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.générerLeTrombinoscopeToolStripMenuItem,
            this.importerListeNOMPrénomToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // générerLeTrombinoscopeToolStripMenuItem
            // 
            this.générerLeTrombinoscopeToolStripMenuItem.Name = "générerLeTrombinoscopeToolStripMenuItem";
            this.générerLeTrombinoscopeToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.générerLeTrombinoscopeToolStripMenuItem.Text = "Générer le trombinoscope";
            this.générerLeTrombinoscopeToolStripMenuItem.Click += new System.EventHandler(this.générerLeTrombinoscopeToolStripMenuItem_Click);
            // 
            // importerListeNOMPrénomToolStripMenuItem
            // 
            this.importerListeNOMPrénomToolStripMenuItem.Name = "importerListeNOMPrénomToolStripMenuItem";
            this.importerListeNOMPrénomToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.importerListeNOMPrénomToolStripMenuItem.Text = "Importer Liste «NOM Prénom»";
            this.importerListeNOMPrénomToolStripMenuItem.Click += new System.EventHandler(this.importerListeNOMPrénomToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(283, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(286, 26);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importerDesPhotosToolStripMenuItem,
            this.importerDepuisDossierToolStripMenuItem,
            this.toolStripSeparator2,
            this.exporterAuFormat35x45ToolStripMenuItem,
            this.renommerLesPhotosToolStripMenuItem});
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.photoToolStripMenuItem.Text = "Photos";
            // 
            // importerDesPhotosToolStripMenuItem
            // 
            this.importerDesPhotosToolStripMenuItem.Name = "importerDesPhotosToolStripMenuItem";
            this.importerDesPhotosToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.importerDesPhotosToolStripMenuItem.Text = "Importer";
            this.importerDesPhotosToolStripMenuItem.Click += new System.EventHandler(this.importerDesPhotosToolStripMenuItem_Click);
            // 
            // importerDepuisDossierToolStripMenuItem
            // 
            this.importerDepuisDossierToolStripMenuItem.Name = "importerDepuisDossierToolStripMenuItem";
            this.importerDepuisDossierToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.importerDepuisDossierToolStripMenuItem.Text = "Importer depuis dossier";
            this.importerDepuisDossierToolStripMenuItem.Click += new System.EventHandler(this.importerDepuisDossierToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(289, 6);
            // 
            // exporterAuFormat35x45ToolStripMenuItem
            // 
            this.exporterAuFormat35x45ToolStripMenuItem.Name = "exporterAuFormat35x45ToolStripMenuItem";
            this.exporterAuFormat35x45ToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.exporterAuFormat35x45ToolStripMenuItem.Text = "Exporter au format 35x45";
            this.exporterAuFormat35x45ToolStripMenuItem.Click += new System.EventHandler(this.exporterAuFormat35x45ToolStripMenuItem_Click);
            // 
            // renommerLesPhotosToolStripMenuItem
            // 
            this.renommerLesPhotosToolStripMenuItem.Name = "renommerLesPhotosToolStripMenuItem";
            this.renommerLesPhotosToolStripMenuItem.Size = new System.Drawing.Size(292, 26);
            this.renommerLesPhotosToolStripMenuItem.Text = "Renommer les photos d\'origine";
            this.renommerLesPhotosToolStripMenuItem.Click += new System.EventHandler(this.renommerLesPhotosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.àProposToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 24);
            this.toolStripMenuItem1.Text = "?";
            // 
            // àProposToolStripMenuItem
            // 
            this.àProposToolStripMenuItem.Name = "àProposToolStripMenuItem";
            this.àProposToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.àProposToolStripMenuItem.Text = "À propos";
            this.àProposToolStripMenuItem.Click += new System.EventHandler(this.àProposToolStripMenuItem_Click);
            // 
            // userListeNoms1
            // 
            this.userListeNoms1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListeNoms1.Location = new System.Drawing.Point(0, 0);
            this.userListeNoms1.Name = "userListeNoms1";
            this.userListeNoms1.Size = new System.Drawing.Size(307, 482);
            this.userListeNoms1.TabIndex = 0;
            this.userListeNoms1.Load += new System.EventHandler(this.userListeNoms1_Load);
            // 
            // userTrombinoscope1
            // 
            this.userTrombinoscope1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userTrombinoscope1.Location = new System.Drawing.Point(0, 0);
            this.userTrombinoscope1.Name = "userTrombinoscope1";
            this.userTrombinoscope1.Size = new System.Drawing.Size(611, 482);
            this.userTrombinoscope1.TabIndex = 0;
            this.userTrombinoscope1.Titre = "";
            this.userTrombinoscope1.Load += new System.EventHandler(this.userTrombinoscope1_Load);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 510);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMain";
            this.Text = "Générateur Trombinoscope & Plan de classe";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserListeNoms userListeNoms1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private UserTrombinoscope userTrombinoscope1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem générerLeTrombinoscopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerListeNOMPrénomToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerDesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerDepuisDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exporterAuFormat35x45ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renommerLesPhotosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem àProposToolStripMenuItem;
    }
}