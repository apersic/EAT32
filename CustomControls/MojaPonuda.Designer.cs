namespace PrijavaRegistracija.CustomControls
{
    partial class MojaPonuda
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
            this.uiContainerArtikliPonude = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiNaslov = new System.Windows.Forms.Label();
            this.uiDodajArtikl = new System.Windows.Forms.Button();
            this.uiKreirajPonudu = new System.Windows.Forms.Button();
            this.uiOdabirPonude = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uiContainerArtikliPonude
            // 
            this.uiContainerArtikliPonude.AutoScroll = true;
            this.uiContainerArtikliPonude.Location = new System.Drawing.Point(32, 121);
            this.uiContainerArtikliPonude.Name = "uiContainerArtikliPonude";
            this.uiContainerArtikliPonude.Size = new System.Drawing.Size(460, 282);
            this.uiContainerArtikliPonude.TabIndex = 68;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(32, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 67;
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(27, 23);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(144, 28);
            this.uiNaslov.TabIndex = 66;
            this.uiNaslov.Text = "Moja ponuda";
            // 
            // uiDodajArtikl
            // 
            this.uiDodajArtikl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiDodajArtikl.FlatAppearance.BorderSize = 0;
            this.uiDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDodajArtikl.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiDodajArtikl.Location = new System.Drawing.Point(141, 77);
            this.uiDodajArtikl.Name = "uiDodajArtikl";
            this.uiDodajArtikl.Size = new System.Drawing.Size(103, 29);
            this.uiDodajArtikl.TabIndex = 69;
            this.uiDodajArtikl.Text = "Dodaj artikl";
            this.uiDodajArtikl.UseVisualStyleBackColor = false;
            this.uiDodajArtikl.Click += new System.EventHandler(this.uiDodajArtikl_Click);
            // 
            // uiKreirajPonudu
            // 
            this.uiKreirajPonudu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiKreirajPonudu.FlatAppearance.BorderSize = 0;
            this.uiKreirajPonudu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiKreirajPonudu.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiKreirajPonudu.Location = new System.Drawing.Point(32, 77);
            this.uiKreirajPonudu.Name = "uiKreirajPonudu";
            this.uiKreirajPonudu.Size = new System.Drawing.Size(103, 29);
            this.uiKreirajPonudu.TabIndex = 70;
            this.uiKreirajPonudu.Text = "Kreiraj ponudu";
            this.uiKreirajPonudu.UseVisualStyleBackColor = false;
            this.uiKreirajPonudu.Click += new System.EventHandler(this.uiKreirajPonudu_Click);
            // 
            // uiOdabirPonude
            // 
            this.uiOdabirPonude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOdabirPonude.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOdabirPonude.FormattingEnabled = true;
            this.uiOdabirPonude.Location = new System.Drawing.Point(250, 77);
            this.uiOdabirPonude.Name = "uiOdabirPonude";
            this.uiOdabirPonude.Size = new System.Drawing.Size(242, 29);
            this.uiOdabirPonude.TabIndex = 71;
            this.uiOdabirPonude.SelectedValueChanged += new System.EventHandler(this.uiOdabirPonude_SelectedValueChanged);
            // 
            // MojaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiOdabirPonude);
            this.Controls.Add(this.uiKreirajPonudu);
            this.Controls.Add(this.uiDodajArtikl);
            this.Controls.Add(this.uiContainerArtikliPonude);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNaslov);
            this.Name = "MojaPonuda";
            this.Size = new System.Drawing.Size(567, 433);
            this.Load += new System.EventHandler(this.MojaPonuda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel uiContainerArtikliPonude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.Button uiDodajArtikl;
        private System.Windows.Forms.Button uiKreirajPonudu;
        private System.Windows.Forms.ComboBox uiOdabirPonude;
    }
}
