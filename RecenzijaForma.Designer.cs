namespace PrijavaRegistracija
{
    partial class RecenzijaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecenzijaForma));
            this.uiNavBarContainer = new System.Windows.Forms.Panel();
            this.uiZatvoriProzor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiKomentar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uiOcjeni = new System.Windows.Forms.Button();
            this.uiOcjenaNarudzbe = new System.Windows.Forms.ComboBox();
            this.uiNavBarContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiNavBarContainer
            // 
            this.uiNavBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiNavBarContainer.Controls.Add(this.uiZatvoriProzor);
            this.uiNavBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.uiNavBarContainer.Name = "uiNavBarContainer";
            this.uiNavBarContainer.Size = new System.Drawing.Size(432, 30);
            this.uiNavBarContainer.TabIndex = 15;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "*Ocjena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Komentar:";
            // 
            // uiKomentar
            // 
            this.uiKomentar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiKomentar.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiKomentar.Location = new System.Drawing.Point(16, 124);
            this.uiKomentar.Multiline = true;
            this.uiKomentar.Name = "uiKomentar";
            this.uiKomentar.Size = new System.Drawing.Size(404, 155);
            this.uiKomentar.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Slab", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 15);
            this.label3.TabIndex = 19;
            this.label3.Text = "* - obvezna polja";
            // 
            // uiOcjeni
            // 
            this.uiOcjeni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiOcjeni.FlatAppearance.BorderSize = 0;
            this.uiOcjeni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOcjeni.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOcjeni.Location = new System.Drawing.Point(334, 303);
            this.uiOcjeni.Name = "uiOcjeni";
            this.uiOcjeni.Size = new System.Drawing.Size(86, 25);
            this.uiOcjeni.TabIndex = 20;
            this.uiOcjeni.Text = "Ocijeni";
            this.uiOcjeni.UseVisualStyleBackColor = false;
            this.uiOcjeni.Click += new System.EventHandler(this.uiOcjeni_Click);
            // 
            // uiOcjenaNarudzbe
            // 
            this.uiOcjenaNarudzbe.FormattingEnabled = true;
            this.uiOcjenaNarudzbe.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.uiOcjenaNarudzbe.Location = new System.Drawing.Point(90, 52);
            this.uiOcjenaNarudzbe.Name = "uiOcjenaNarudzbe";
            this.uiOcjenaNarudzbe.Size = new System.Drawing.Size(121, 21);
            this.uiOcjenaNarudzbe.TabIndex = 22;
            // 
            // RecenzijaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 340);
            this.Controls.Add(this.uiOcjenaNarudzbe);
            this.Controls.Add(this.uiOcjeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uiKomentar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiNavBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecenzijaForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecenzijaForma";
            this.Load += new System.EventHandler(this.RecenzijaForma_Load);
            this.uiNavBarContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel uiNavBarContainer;
        private System.Windows.Forms.Button uiZatvoriProzor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uiKomentar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiOcjeni;
        private System.Windows.Forms.ComboBox uiOcjenaNarudzbe;
    }
}