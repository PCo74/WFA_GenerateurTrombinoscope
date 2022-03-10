namespace WFA_GenerateurTrombinoscope
{
    partial class FormCropPhoto
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
            this.userPortrait1 = new AWF_crop_image.UserPortrait();
            this.SuspendLayout();
            // 
            // userPortrait1
            // 
            this.userPortrait1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPortrait1.IsMarked = true;
            this.userPortrait1.Location = new System.Drawing.Point(0, 0);
            this.userPortrait1.Name = "userPortrait1";
            this.userPortrait1.PathImage = "";
            this.userPortrait1.Size = new System.Drawing.Size(373, 473);
            this.userPortrait1.TabIndex = 0;
            this.userPortrait1.ButtonOkClick += new System.EventHandler(this.userPortrait1_ButtonOkClick);
            // 
            // FormCropPhoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 507);
            this.Controls.Add(this.userPortrait1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCropPhoto";
            this.Text = "Recadrage de photo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCropPhoto_FormClosing);
            this.ResizeEnd += new System.EventHandler(this.FormCropPhoto_ResizeEnd);
            this.Move += new System.EventHandler(this.FormCropPhoto_Move);
            this.ResumeLayout(false);

        }

        #endregion

        public AWF_crop_image.UserPortrait userPortrait1;
    }
}