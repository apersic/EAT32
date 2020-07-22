namespace PrijavaRegistracija.CustomControls
{
    partial class PrikazArtikla
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
            this.uiNazivArtikla = new System.Windows.Forms.Label();
            this.uiCijenaArtikla = new System.Windows.Forms.Label();
            this.uiIzbrisiArtikl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiNazivArtikla
            // 
            this.uiNazivArtikla.AutoSize = true;
            this.uiNazivArtikla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiNazivArtikla.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNazivArtikla.Location = new System.Drawing.Point(13, 12);
            this.uiNazivArtikla.Name = "uiNazivArtikla";
            this.uiNazivArtikla.Size = new System.Drawing.Size(58, 21);
            this.uiNazivArtikla.TabIndex = 3;
            this.uiNazivArtikla.Text = "Naziv";
            // 
            // uiCijenaArtikla
            // 
            this.uiCijenaArtikla.AutoSize = true;
            this.uiCijenaArtikla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCijenaArtikla.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiCijenaArtikla.Location = new System.Drawing.Point(200, 12);
            this.uiCijenaArtikla.Name = "uiCijenaArtikla";
            this.uiCijenaArtikla.Size = new System.Drawing.Size(63, 21);
            this.uiCijenaArtikla.TabIndex = 4;
            this.uiCijenaArtikla.Text = "Cijena";
            // 
            // uiIzbrisiArtikl
            // 
            this.uiIzbrisiArtikl.FlatAppearance.BorderSize = 0;
            this.uiIzbrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIzbrisiArtikl.Image = global::PrijavaRegistracija.Properties.Resources.icons8_cancel_32;
            this.uiIzbrisiArtikl.Location = new System.Drawing.Point(389, 6);
            this.uiIzbrisiArtikl.Name = "uiIzbrisiArtikl";
            this.uiIzbrisiArtikl.Size = new System.Drawing.Size(32, 32);
            this.uiIzbrisiArtikl.TabIndex = 5;
            this.uiIzbrisiArtikl.UseVisualStyleBackColor = true;
            this.uiIzbrisiArtikl.Click += new System.EventHandler(this.uiIzbrisiArtikl_Click);
            // 
            // PrikazArtikla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiIzbrisiArtikl);
            this.Controls.Add(this.uiCijenaArtikla);
            this.Controls.Add(this.uiNazivArtikla);
            this.Name = "PrikazArtikla";
            this.Size = new System.Drawing.Size(458, 45);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiNazivArtikla;
        private System.Windows.Forms.Label uiCijenaArtikla;
        private System.Windows.Forms.Button uiIzbrisiArtikl;
    }
}
