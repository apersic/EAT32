namespace PrijavaRegistracija.CustomControls
{
    partial class Navigacija
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uiNavigacijaPrikaz = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // uiNavigacijaPrikaz
            // 
            this.uiNavigacijaPrikaz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiNavigacijaPrikaz.Location = new System.Drawing.Point(0, 0);
            this.uiNavigacijaPrikaz.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiNavigacijaPrikaz.Name = "uiNavigacijaPrikaz";
            this.uiNavigacijaPrikaz.Size = new System.Drawing.Size(711, 441);
            this.uiNavigacijaPrikaz.TabIndex = 0;
            this.uiNavigacijaPrikaz.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.uiNavigacija_DocumentCompleted);
            // 
            // Navigacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiNavigacijaPrikaz);
            this.Name = "Navigacija";
            this.Size = new System.Drawing.Size(711, 441);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser uiNavigacijaPrikaz;
    }
}
