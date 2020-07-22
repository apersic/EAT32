namespace PrijavaRegistracija.CustomControls
{
    partial class PrikazRecenzije
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
            this.uiKorisnickoImeOP = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiRecenzijaOcjena = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiRecenzijaTekst = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiKorisnickoImeOP
            // 
            this.uiKorisnickoImeOP.AutoSize = true;
            this.uiKorisnickoImeOP.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiKorisnickoImeOP.Location = new System.Drawing.Point(12, 10);
            this.uiKorisnickoImeOP.Name = "uiKorisnickoImeOP";
            this.uiKorisnickoImeOP.Size = new System.Drawing.Size(95, 16);
            this.uiKorisnickoImeOP.TabIndex = 0;
            this.uiKorisnickoImeOP.Text = "Korisničko ime";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(15, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 2);
            this.panel1.TabIndex = 1;
            // 
            // uiRecenzijaOcjena
            // 
            this.uiRecenzijaOcjena.AutoSize = true;
            this.uiRecenzijaOcjena.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiRecenzijaOcjena.Location = new System.Drawing.Point(247, 6);
            this.uiRecenzijaOcjena.Name = "uiRecenzijaOcjena";
            this.uiRecenzijaOcjena.Size = new System.Drawing.Size(17, 20);
            this.uiRecenzijaOcjena.TabIndex = 2;
            this.uiRecenzijaOcjena.Text = "2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PrijavaRegistracija.Properties.Resources.icons8_christmas_star_24;
            this.pictureBox1.Location = new System.Drawing.Point(218, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 26);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // uiRecenzijaTekst
            // 
            this.uiRecenzijaTekst.BackColor = System.Drawing.SystemColors.Control;
            this.uiRecenzijaTekst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiRecenzijaTekst.Enabled = false;
            this.uiRecenzijaTekst.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiRecenzijaTekst.Location = new System.Drawing.Point(15, 37);
            this.uiRecenzijaTekst.Multiline = true;
            this.uiRecenzijaTekst.Name = "uiRecenzijaTekst";
            this.uiRecenzijaTekst.Size = new System.Drawing.Size(626, 81);
            this.uiRecenzijaTekst.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(15, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 2);
            this.panel2.TabIndex = 5;
            // 
            // PrikazRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.uiRecenzijaTekst);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiRecenzijaOcjena);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiKorisnickoImeOP);
            this.Name = "PrikazRecenzije";
            this.Size = new System.Drawing.Size(657, 131);
            this.Load += new System.EventHandler(this.PrikazRecenzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiKorisnickoImeOP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiRecenzijaOcjena;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox uiRecenzijaTekst;
        private System.Windows.Forms.Panel panel2;
    }
}
