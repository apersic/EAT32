namespace PrijavaRegistracija.CustomControls
{
    partial class NarudzbaPrikaz
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
            this.uiOznakaNaslov = new System.Windows.Forms.Label();
            this.uiPopisMojihNarudzbi = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // uiOznakaNaslov
            // 
            this.uiOznakaNaslov.AutoSize = true;
            this.uiOznakaNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNaslov.Location = new System.Drawing.Point(23, 11);
            this.uiOznakaNaslov.Name = "uiOznakaNaslov";
            this.uiOznakaNaslov.Size = new System.Drawing.Size(161, 28);
            this.uiOznakaNaslov.TabIndex = 11;
            this.uiOznakaNaslov.Text = "Moje narudžbe";
            // 
            // uiPopisMojihNarudzbi
            // 
            this.uiPopisMojihNarudzbi.AutoScroll = true;
            this.uiPopisMojihNarudzbi.Location = new System.Drawing.Point(28, 42);
            this.uiPopisMojihNarudzbi.Name = "uiPopisMojihNarudzbi";
            this.uiPopisMojihNarudzbi.Size = new System.Drawing.Size(508, 364);
            this.uiPopisMojihNarudzbi.TabIndex = 12;
            // 
            // NarudzbaPrikaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPopisMojihNarudzbi);
            this.Controls.Add(this.uiOznakaNaslov);
            this.Name = "NarudzbaPrikaz";
            this.Size = new System.Drawing.Size(567, 433);
            this.Load += new System.EventHandler(this.NarudzbaPrikaz_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiOznakaNaslov;
        private System.Windows.Forms.FlowLayoutPanel uiPopisMojihNarudzbi;
    }
}
