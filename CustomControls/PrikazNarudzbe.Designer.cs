namespace PrijavaRegistracija.CustomControls
{
    partial class PrikazNarudzbe
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
            this.uiBtnProsiri = new System.Windows.Forms.Button();
            this.uiOznakaNarudzba = new System.Windows.Forms.Label();
            this.uiOznakaKontrola = new System.Windows.Forms.Label();
            this.uiPopisStavki = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uiBtnProsiri
            // 
            this.uiBtnProsiri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiBtnProsiri.FlatAppearance.BorderSize = 0;
            this.uiBtnProsiri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnProsiri.Image = global::PrijavaRegistracija.Properties.Resources.icons8_expand_arrow_24;
            this.uiBtnProsiri.Location = new System.Drawing.Point(418, 12);
            this.uiBtnProsiri.Name = "uiBtnProsiri";
            this.uiBtnProsiri.Size = new System.Drawing.Size(24, 24);
            this.uiBtnProsiri.TabIndex = 0;
            this.uiBtnProsiri.UseVisualStyleBackColor = true;
            this.uiBtnProsiri.Click += new System.EventHandler(this.uiBtnProsiri_Click);
            // 
            // uiOznakaNarudzba
            // 
            this.uiOznakaNarudzba.AutoSize = true;
            this.uiOznakaNarudzba.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiOznakaNarudzba.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNarudzba.Location = new System.Drawing.Point(129, 12);
            this.uiOznakaNarudzba.Margin = new System.Windows.Forms.Padding(0);
            this.uiOznakaNarudzba.Name = "uiOznakaNarudzba";
            this.uiOznakaNarudzba.Size = new System.Drawing.Size(57, 21);
            this.uiOznakaNarudzba.TabIndex = 1;
            this.uiOznakaNarudzba.Text = "12345";
            this.uiOznakaNarudzba.Click += new System.EventHandler(this.uiOznakaNarudzba_Click);
            // 
            // uiOznakaKontrola
            // 
            this.uiOznakaKontrola.AutoSize = true;
            this.uiOznakaKontrola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiOznakaKontrola.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaKontrola.Location = new System.Drawing.Point(18, 12);
            this.uiOznakaKontrola.Name = "uiOznakaKontrola";
            this.uiOznakaKontrola.Size = new System.Drawing.Size(118, 21);
            this.uiOznakaKontrola.TabIndex = 2;
            this.uiOznakaKontrola.Text = "Narudžba   #";
            this.uiOznakaKontrola.Click += new System.EventHandler(this.uiOznakaKontrola_Click);
            // 
            // uiPopisStavki
            // 
            this.uiPopisStavki.Location = new System.Drawing.Point(118, 40);
            this.uiPopisStavki.Multiline = true;
            this.uiPopisStavki.Name = "uiPopisStavki";
            this.uiPopisStavki.Size = new System.Drawing.Size(197, 64);
            this.uiPopisStavki.TabIndex = 3;
            this.uiPopisStavki.Visible = false;
            // 
            // PrikazNarudzbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPopisStavki);
            this.Controls.Add(this.uiOznakaNarudzba);
            this.Controls.Add(this.uiBtnProsiri);
            this.Controls.Add(this.uiOznakaKontrola);
            this.Name = "PrikazNarudzbe";
            this.Size = new System.Drawing.Size(454, 46);
            this.Load += new System.EventHandler(this.PrikazNarudzbe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uiBtnProsiri;
        private System.Windows.Forms.Label uiOznakaNarudzba;
        private System.Windows.Forms.Label uiOznakaKontrola;
        private System.Windows.Forms.TextBox uiPopisStavki;
    }
}
