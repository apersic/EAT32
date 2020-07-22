namespace PrijavaRegistracija.CustomControls
{
    partial class Narudzba
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
            this.uiImeUgostiteljkogObjekta = new System.Windows.Forms.Label();
            this.uiDatumNarudzbe = new System.Windows.Forms.Label();
            this.uiOcijeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiImeUgostiteljkogObjekta
            // 
            this.uiImeUgostiteljkogObjekta.AutoSize = true;
            this.uiImeUgostiteljkogObjekta.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiImeUgostiteljkogObjekta.Location = new System.Drawing.Point(3, 9);
            this.uiImeUgostiteljkogObjekta.Name = "uiImeUgostiteljkogObjekta";
            this.uiImeUgostiteljkogObjekta.Size = new System.Drawing.Size(208, 28);
            this.uiImeUgostiteljkogObjekta.TabIndex = 12;
            this.uiImeUgostiteljkogObjekta.Text = "Ugostiteljski objekt";
            // 
            // uiDatumNarudzbe
            // 
            this.uiDatumNarudzbe.AutoSize = true;
            this.uiDatumNarudzbe.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiDatumNarudzbe.Location = new System.Drawing.Point(4, 47);
            this.uiDatumNarudzbe.Name = "uiDatumNarudzbe";
            this.uiDatumNarudzbe.Size = new System.Drawing.Size(61, 21);
            this.uiDatumNarudzbe.TabIndex = 13;
            this.uiDatumNarudzbe.Text = "Datum";
            // 
            // uiOcijeni
            // 
            this.uiOcijeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiOcijeni.FlatAppearance.BorderSize = 0;
            this.uiOcijeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOcijeni.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOcijeni.Location = new System.Drawing.Point(407, 47);
            this.uiOcijeni.Name = "uiOcijeni";
            this.uiOcijeni.Size = new System.Drawing.Size(89, 30);
            this.uiOcijeni.TabIndex = 14;
            this.uiOcijeni.Text = "Ocijeni";
            this.uiOcijeni.UseVisualStyleBackColor = false;
            this.uiOcijeni.Click += new System.EventHandler(this.uiOcijeni_Click);
            // 
            // Narudzba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiOcijeni);
            this.Controls.Add(this.uiDatumNarudzbe);
            this.Controls.Add(this.uiImeUgostiteljkogObjekta);
            this.Name = "Narudzba";
            this.Size = new System.Drawing.Size(508, 90);
            this.Load += new System.EventHandler(this.Narudzba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiImeUgostiteljkogObjekta;
        private System.Windows.Forms.Label uiDatumNarudzbe;
        private System.Windows.Forms.Button uiOcijeni;
    }
}
