namespace PrijavaRegistracija
{
    partial class NovaPonuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaPonuda));
            this.uiNavBarContainer = new System.Windows.Forms.Panel();
            this.uiZatvoriProzor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uiOznakaNaziv = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uiUnosOpis = new System.Windows.Forms.TextBox();
            this.uiNaslov = new System.Windows.Forms.Label();
            this.uiUpozorenjeZauzetoKorisnickoIme = new System.Windows.Forms.Label();
            this.uiSpremi = new System.Windows.Forms.Button();
            this.uiUpozorenjeLozinka = new System.Windows.Forms.Label();
            this.uiNavBarContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNavBarContainer
            // 
            this.uiNavBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiNavBarContainer.Controls.Add(this.uiZatvoriProzor);
            this.uiNavBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.uiNavBarContainer.Name = "uiNavBarContainer";
            this.uiNavBarContainer.Size = new System.Drawing.Size(335, 30);
            this.uiNavBarContainer.TabIndex = 70;
            // 
            // uiZatvoriProzor
            // 
            this.uiZatvoriProzor.FlatAppearance.BorderSize = 0;
            this.uiZatvoriProzor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiZatvoriProzor.Image = ((System.Drawing.Image)(resources.GetObject("uiZatvoriProzor.Image")));
            this.uiZatvoriProzor.Location = new System.Drawing.Point(305, 3);
            this.uiZatvoriProzor.Name = "uiZatvoriProzor";
            this.uiZatvoriProzor.Size = new System.Drawing.Size(22, 22);
            this.uiZatvoriProzor.TabIndex = 3;
            this.uiZatvoriProzor.UseVisualStyleBackColor = true;
            this.uiZatvoriProzor.Click += new System.EventHandler(this.uiZatvoriProzor_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.uiOznakaNaziv);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.uiNaslov);
            this.panel1.Controls.Add(this.uiUpozorenjeZauzetoKorisnickoIme);
            this.panel1.Controls.Add(this.uiSpremi);
            this.panel1.Controls.Add(this.uiUpozorenjeLozinka);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 165);
            this.panel1.TabIndex = 71;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(20, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 87;
            // 
            // uiOznakaNaziv
            // 
            this.uiOznakaNaziv.AutoSize = true;
            this.uiOznakaNaziv.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNaziv.Location = new System.Drawing.Point(25, 63);
            this.uiOznakaNaziv.Name = "uiOznakaNaziv";
            this.uiOznakaNaziv.Size = new System.Drawing.Size(42, 20);
            this.uiOznakaNaziv.TabIndex = 81;
            this.uiOznakaNaziv.Text = "Opis";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.uiUnosOpis);
            this.panel3.Location = new System.Drawing.Point(83, 59);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 30);
            this.panel3.TabIndex = 82;
            // 
            // uiUnosOpis
            // 
            this.uiUnosOpis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiUnosOpis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiUnosOpis.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosOpis.Location = new System.Drawing.Point(5, 5);
            this.uiUnosOpis.Name = "uiUnosOpis";
            this.uiUnosOpis.Size = new System.Drawing.Size(197, 18);
            this.uiUnosOpis.TabIndex = 1;
            this.uiUnosOpis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(15, 9);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(131, 25);
            this.uiNaslov.TabIndex = 86;
            this.uiNaslov.Text = "Nova ponuda";
            // 
            // uiUpozorenjeZauzetoKorisnickoIme
            // 
            this.uiUpozorenjeZauzetoKorisnickoIme.AutoSize = true;
            this.uiUpozorenjeZauzetoKorisnickoIme.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUpozorenjeZauzetoKorisnickoIme.ForeColor = System.Drawing.Color.Red;
            this.uiUpozorenjeZauzetoKorisnickoIme.Location = new System.Drawing.Point(318, 32);
            this.uiUpozorenjeZauzetoKorisnickoIme.Name = "uiUpozorenjeZauzetoKorisnickoIme";
            this.uiUpozorenjeZauzetoKorisnickoIme.Size = new System.Drawing.Size(0, 20);
            this.uiUpozorenjeZauzetoKorisnickoIme.TabIndex = 83;
            // 
            // uiSpremi
            // 
            this.uiSpremi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.uiSpremi.FlatAppearance.BorderSize = 0;
            this.uiSpremi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSpremi.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSpremi.Location = new System.Drawing.Point(181, 110);
            this.uiSpremi.Name = "uiSpremi";
            this.uiSpremi.Size = new System.Drawing.Size(109, 32);
            this.uiSpremi.TabIndex = 85;
            this.uiSpremi.Text = "Kreiraj";
            this.uiSpremi.UseVisualStyleBackColor = false;
            this.uiSpremi.Click += new System.EventHandler(this.uiSpremi_Click_1);
            // 
            // uiUpozorenjeLozinka
            // 
            this.uiUpozorenjeLozinka.AutoSize = true;
            this.uiUpozorenjeLozinka.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUpozorenjeLozinka.ForeColor = System.Drawing.Color.Red;
            this.uiUpozorenjeLozinka.Location = new System.Drawing.Point(318, 80);
            this.uiUpozorenjeLozinka.Name = "uiUpozorenjeLozinka";
            this.uiUpozorenjeLozinka.Size = new System.Drawing.Size(0, 20);
            this.uiUpozorenjeLozinka.TabIndex = 84;
            // 
            // NovaPonuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNavBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovaPonuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaPonuda";
            this.uiNavBarContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel uiNavBarContainer;
        private System.Windows.Forms.Button uiZatvoriProzor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label uiOznakaNaziv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox uiUnosOpis;
        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.Label uiUpozorenjeZauzetoKorisnickoIme;
        private System.Windows.Forms.Button uiSpremi;
        private System.Windows.Forms.Label uiUpozorenjeLozinka;
    }
}