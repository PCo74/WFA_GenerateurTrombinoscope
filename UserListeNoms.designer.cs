namespace WFA_GenerateurTrombinoscope
{
    partial class UserListeNoms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListeNoms));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonImporterCSV = new System.Windows.Forms.Button();
            this.buttonRetirer = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "\r\nListe\r\n«NOM Prénom»";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonImporterCSV);
            this.splitContainer1.Panel1.Controls.Add(this.buttonRetirer);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(249, 473);
            this.splitContainer1.SplitterDistance = 48;
            this.splitContainer1.TabIndex = 1;
            // 
            // buttonImporterCSV
            // 
            this.buttonImporterCSV.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonImporterCSV.Image = global::WFA_GenerateurTrombinoscope.Properties.Resources.file_import_outline_36;
            this.buttonImporterCSV.Location = new System.Drawing.Point(133, 0);
            this.buttonImporterCSV.Name = "buttonImporterCSV";
            this.buttonImporterCSV.Size = new System.Drawing.Size(58, 48);
            this.buttonImporterCSV.TabIndex = 1;
            this.buttonImporterCSV.Text = ",";
            this.toolTip1.SetToolTip(this.buttonImporterCSV, "Importer un fichier CSV");
            this.buttonImporterCSV.UseVisualStyleBackColor = true;
            this.buttonImporterCSV.Click += new System.EventHandler(this.buttonImporterCSV_Click);
            // 
            // buttonRetirer
            // 
            this.buttonRetirer.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRetirer.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetirer.Image")));
            this.buttonRetirer.Location = new System.Drawing.Point(191, 0);
            this.buttonRetirer.Name = "buttonRetirer";
            this.buttonRetirer.Size = new System.Drawing.Size(58, 48);
            this.buttonRetirer.TabIndex = 2;
            this.toolTip1.SetToolTip(this.buttonRetirer, "Retirer les éléments sélectionnés");
            this.buttonRetirer.UseVisualStyleBackColor = true;
            this.buttonRetirer.Click += new System.EventHandler(this.buttonRetirer_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(249, 421);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // UserListeNoms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UserListeNoms";
            this.Size = new System.Drawing.Size(249, 473);
            this.Load += new System.EventHandler(this.UserListeNoms_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonImporterCSV;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRetirer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
