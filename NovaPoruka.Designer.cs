namespace PrijavaRegistracija
{
    partial class NovaPoruka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaPoruka));
            this.uiOznakaPrimatelj = new System.Windows.Forms.Label();
            this.uiOznakaNaslov = new System.Windows.Forms.Label();
            this.uiContainerPrimatelj = new System.Windows.Forms.Panel();
            this.uiUnosPrimatelj = new System.Windows.Forms.TextBox();
            this.uiContainerNaslov = new System.Windows.Forms.Panel();
            this.uiUnosNaslov = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiUnosTekst = new System.Windows.Forms.TextBox();
            this.uiOznakaTekst = new System.Windows.Forms.Label();
            this.uiPosaljiPoruku = new System.Windows.Forms.Button();
            this.uiUpozorenjePrimatelj = new System.Windows.Forms.Label();
            this.uiUpozorenjeNaslov = new System.Windows.Forms.Label();
            this.uiNavBarContainer = new System.Windows.Forms.Panel();
            this.uiZatvoriProzor = new System.Windows.Forms.Button();
            this.uiFormBorder = new System.Windows.Forms.Panel();
            this.uiContainerPrimatelj.SuspendLayout();
            this.uiContainerNaslov.SuspendLayout();
            this.panel1.SuspendLayout();
            this.uiNavBarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiOznakaPrimatelj
            // 
            this.uiOznakaPrimatelj.AutoSize = true;
            this.uiOznakaPrimatelj.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaPrimatelj.Location = new System.Drawing.Point(23, 49);
            this.uiOznakaPrimatelj.Name = "uiOznakaPrimatelj";
            this.uiOznakaPrimatelj.Size = new System.Drawing.Size(80, 21);
            this.uiOznakaPrimatelj.TabIndex = 0;
            this.uiOznakaPrimatelj.Text = "Primatelj";
            // 
            // uiOznakaNaslov
            // 
            this.uiOznakaNaslov.AutoSize = true;
            this.uiOznakaNaslov.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNaslov.Location = new System.Drawing.Point(41, 90);
            this.uiOznakaNaslov.Name = "uiOznakaNaslov";
            this.uiOznakaNaslov.Size = new System.Drawing.Size(62, 21);
            this.uiOznakaNaslov.TabIndex = 1;
            this.uiOznakaNaslov.Text = "Naslov";
            // 
            // uiContainerPrimatelj
            // 
            this.uiContainerPrimatelj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiContainerPrimatelj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiContainerPrimatelj.Controls.Add(this.uiUnosPrimatelj);
            this.uiContainerPrimatelj.Location = new System.Drawing.Point(109, 45);
            this.uiContainerPrimatelj.Name = "uiContainerPrimatelj";
            this.uiContainerPrimatelj.Size = new System.Drawing.Size(150, 32);
            this.uiContainerPrimatelj.TabIndex = 8;
            // 
            // uiUnosPrimatelj
            // 
            this.uiUnosPrimatelj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiUnosPrimatelj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiUnosPrimatelj.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosPrimatelj.Location = new System.Drawing.Point(11, 7);
            this.uiUnosPrimatelj.Name = "uiUnosPrimatelj";
            this.uiUnosPrimatelj.Size = new System.Drawing.Size(128, 18);
            this.uiUnosPrimatelj.TabIndex = 1;
            this.uiUnosPrimatelj.TextChanged += new System.EventHandler(this.uiUnosPrimatelj_TextChanged);
            // 
            // uiContainerNaslov
            // 
            this.uiContainerNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiContainerNaslov.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiContainerNaslov.Controls.Add(this.uiUnosNaslov);
            this.uiContainerNaslov.Location = new System.Drawing.Point(109, 85);
            this.uiContainerNaslov.Name = "uiContainerNaslov";
            this.uiContainerNaslov.Size = new System.Drawing.Size(150, 32);
            this.uiContainerNaslov.TabIndex = 7;
            // 
            // uiUnosNaslov
            // 
            this.uiUnosNaslov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiUnosNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiUnosNaslov.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosNaslov.Location = new System.Drawing.Point(11, 8);
            this.uiUnosNaslov.Name = "uiUnosNaslov";
            this.uiUnosNaslov.Size = new System.Drawing.Size(128, 16);
            this.uiUnosNaslov.TabIndex = 2;
            this.uiUnosNaslov.Leave += new System.EventHandler(this.uiUnosNaslov_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.uiUnosTekst);
            this.panel1.Location = new System.Drawing.Point(109, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 158);
            this.panel1.TabIndex = 8;
            // 
            // uiUnosTekst
            // 
            this.uiUnosTekst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.uiUnosTekst.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiUnosTekst.Font = new System.Drawing.Font("Roboto Slab", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosTekst.Location = new System.Drawing.Point(11, 9);
            this.uiUnosTekst.Multiline = true;
            this.uiUnosTekst.Name = "uiUnosTekst";
            this.uiUnosTekst.Size = new System.Drawing.Size(271, 135);
            this.uiUnosTekst.TabIndex = 2;
            // 
            // uiOznakaTekst
            // 
            this.uiOznakaTekst.AutoSize = true;
            this.uiOznakaTekst.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaTekst.Location = new System.Drawing.Point(36, 128);
            this.uiOznakaTekst.Name = "uiOznakaTekst";
            this.uiOznakaTekst.Size = new System.Drawing.Size(67, 21);
            this.uiOznakaTekst.TabIndex = 10;
            this.uiOznakaTekst.Text = "Sadrzaj";
            // 
            // uiPosaljiPoruku
            // 
            this.uiPosaljiPoruku.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiPosaljiPoruku.FlatAppearance.BorderSize = 0;
            this.uiPosaljiPoruku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPosaljiPoruku.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiPosaljiPoruku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uiPosaljiPoruku.Location = new System.Drawing.Point(301, 295);
            this.uiPosaljiPoruku.Name = "uiPosaljiPoruku";
            this.uiPosaljiPoruku.Size = new System.Drawing.Size(106, 31);
            this.uiPosaljiPoruku.TabIndex = 11;
            this.uiPosaljiPoruku.Text = "Posalji";
            this.uiPosaljiPoruku.UseVisualStyleBackColor = false;
            this.uiPosaljiPoruku.Click += new System.EventHandler(this.uiPosaljiPoruku_Click);
            // 
            // uiUpozorenjePrimatelj
            // 
            this.uiUpozorenjePrimatelj.AutoSize = true;
            this.uiUpozorenjePrimatelj.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUpozorenjePrimatelj.ForeColor = System.Drawing.Color.Red;
            this.uiUpozorenjePrimatelj.Location = new System.Drawing.Point(265, 53);
            this.uiUpozorenjePrimatelj.Name = "uiUpozorenjePrimatelj";
            this.uiUpozorenjePrimatelj.Size = new System.Drawing.Size(0, 18);
            this.uiUpozorenjePrimatelj.TabIndex = 12;
            // 
            // uiUpozorenjeNaslov
            // 
            this.uiUpozorenjeNaslov.AutoSize = true;
            this.uiUpozorenjeNaslov.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUpozorenjeNaslov.ForeColor = System.Drawing.Color.Red;
            this.uiUpozorenjeNaslov.Location = new System.Drawing.Point(265, 93);
            this.uiUpozorenjeNaslov.Name = "uiUpozorenjeNaslov";
            this.uiUpozorenjeNaslov.Size = new System.Drawing.Size(0, 18);
            this.uiUpozorenjeNaslov.TabIndex = 13;
            // 
            // uiNavBarContainer
            // 
            this.uiNavBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiNavBarContainer.Controls.Add(this.uiZatvoriProzor);
            this.uiNavBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.uiNavBarContainer.Name = "uiNavBarContainer";
            this.uiNavBarContainer.Size = new System.Drawing.Size(432, 30);
            this.uiNavBarContainer.TabIndex = 14;
            // 
            // uiZatvoriProzor
            // 
            this.uiZatvoriProzor.FlatAppearance.BorderSize = 0;
            this.uiZatvoriProzor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiZatvoriProzor.Image = ((System.Drawing.Image)(resources.GetObject("uiZatvoriProzor.Image")));
            this.uiZatvoriProzor.Location = new System.Drawing.Point(398, 3);
            this.uiZatvoriProzor.Name = "uiZatvoriProzor";
            this.uiZatvoriProzor.Size = new System.Drawing.Size(22, 22);
            this.uiZatvoriProzor.TabIndex = 3;
            this.uiZatvoriProzor.UseVisualStyleBackColor = true;
            this.uiZatvoriProzor.Click += new System.EventHandler(this.uiZatvoriProzor_Click);
            // 
            // uiFormBorder
            // 
            this.uiFormBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiFormBorder.Location = new System.Drawing.Point(0, 0);
            this.uiFormBorder.Name = "uiFormBorder";
            this.uiFormBorder.Size = new System.Drawing.Size(432, 339);
            this.uiFormBorder.TabIndex = 15;
            // 
            // NovaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(432, 340);
            this.Controls.Add(this.uiNavBarContainer);
            this.Controls.Add(this.uiUpozorenjeNaslov);
            this.Controls.Add(this.uiUpozorenjePrimatelj);
            this.Controls.Add(this.uiPosaljiPoruku);
            this.Controls.Add(this.uiOznakaTekst);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiContainerPrimatelj);
            this.Controls.Add(this.uiContainerNaslov);
            this.Controls.Add(this.uiOznakaNaslov);
            this.Controls.Add(this.uiOznakaPrimatelj);
            this.Controls.Add(this.uiFormBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovaPoruka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova poruka";
            this.uiContainerPrimatelj.ResumeLayout(false);
            this.uiContainerPrimatelj.PerformLayout();
            this.uiContainerNaslov.ResumeLayout(false);
            this.uiContainerNaslov.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.uiNavBarContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiOznakaPrimatelj;
        private System.Windows.Forms.Label uiOznakaNaslov;
        private System.Windows.Forms.Panel uiContainerPrimatelj;
        private System.Windows.Forms.TextBox uiUnosPrimatelj;
        private System.Windows.Forms.Panel uiContainerNaslov;
        private System.Windows.Forms.TextBox uiUnosNaslov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox uiUnosTekst;
        private System.Windows.Forms.Label uiOznakaTekst;
        private System.Windows.Forms.Button uiPosaljiPoruku;
        private System.Windows.Forms.Label uiUpozorenjePrimatelj;
        private System.Windows.Forms.Label uiUpozorenjeNaslov;
        private System.Windows.Forms.Panel uiNavBarContainer;
        private System.Windows.Forms.Button uiZatvoriProzor;
        private System.Windows.Forms.Panel uiFormBorder;
    }
}