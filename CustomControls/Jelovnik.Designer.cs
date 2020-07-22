namespace PrijavaRegistracija.CustomControls
{
    partial class Jelovnik
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
            this.uiOdabirPonude = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiNaslov = new System.Windows.Forms.Label();
            this.uiJelovnikContainer = new System.Windows.Forms.DataGridView();
            this.uiNarudzbaContainer = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.uiIzbrisiArtikl = new System.Windows.Forms.Button();
            this.uiDodajArtikl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.uiIznosNarudzbe = new System.Windows.Forms.Label();
            this.uiNaruci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uiJelovnikContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNarudzbaContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOdabirPonude
            // 
            this.uiOdabirPonude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOdabirPonude.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOdabirPonude.FormattingEnabled = true;
            this.uiOdabirPonude.Location = new System.Drawing.Point(90, 79);
            this.uiOdabirPonude.Name = "uiOdabirPonude";
            this.uiOdabirPonude.Size = new System.Drawing.Size(242, 29);
            this.uiOdabirPonude.TabIndex = 77;
            this.uiOdabirPonude.SelectedIndexChanged += new System.EventHandler(this.uiOdabirPonude_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(90, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 2);
            this.panel1.TabIndex = 73;
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(85, 30);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(100, 28);
            this.uiNaslov.TabIndex = 72;
            this.uiNaslov.Text = "Jelovnik";
            // 
            // uiJelovnikContainer
            // 
            this.uiJelovnikContainer.AllowUserToAddRows = false;
            this.uiJelovnikContainer.AllowUserToDeleteRows = false;
            this.uiJelovnikContainer.AllowUserToResizeColumns = false;
            this.uiJelovnikContainer.AllowUserToResizeRows = false;
            this.uiJelovnikContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiJelovnikContainer.Location = new System.Drawing.Point(90, 123);
            this.uiJelovnikContainer.Name = "uiJelovnikContainer";
            this.uiJelovnikContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiJelovnikContainer.Size = new System.Drawing.Size(242, 261);
            this.uiJelovnikContainer.TabIndex = 0;
            // 
            // uiNarudzbaContainer
            // 
            this.uiNarudzbaContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.uiNarudzbaContainer.Location = new System.Drawing.Point(408, 123);
            this.uiNarudzbaContainer.Name = "uiNarudzbaContainer";
            this.uiNarudzbaContainer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.uiNarudzbaContainer.Size = new System.Drawing.Size(242, 261);
            this.uiNarudzbaContainer.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(404, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 80;
            this.label1.Text = "Moja Narudžba";
            // 
            // uiIzbrisiArtikl
            // 
            this.uiIzbrisiArtikl.FlatAppearance.BorderSize = 0;
            this.uiIzbrisiArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiIzbrisiArtikl.Image = global::PrijavaRegistracija.Properties.Resources.icons8_cancel_32;
            this.uiIzbrisiArtikl.Location = new System.Drawing.Point(354, 248);
            this.uiIzbrisiArtikl.Name = "uiIzbrisiArtikl";
            this.uiIzbrisiArtikl.Size = new System.Drawing.Size(32, 32);
            this.uiIzbrisiArtikl.TabIndex = 81;
            this.uiIzbrisiArtikl.UseVisualStyleBackColor = true;
            this.uiIzbrisiArtikl.Click += new System.EventHandler(this.uiIzbrisiArtikl_Click);
            // 
            // uiDodajArtikl
            // 
            this.uiDodajArtikl.FlatAppearance.BorderSize = 0;
            this.uiDodajArtikl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiDodajArtikl.Image = global::PrijavaRegistracija.Properties.Resources.icons8_plus_32;
            this.uiDodajArtikl.Location = new System.Drawing.Point(354, 190);
            this.uiDodajArtikl.Name = "uiDodajArtikl";
            this.uiDodajArtikl.Size = new System.Drawing.Size(32, 32);
            this.uiDodajArtikl.TabIndex = 79;
            this.uiDodajArtikl.UseVisualStyleBackColor = true;
            this.uiDodajArtikl.Click += new System.EventHandler(this.uiDodajArtikl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(404, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 82;
            this.label2.Text = "Iznos:";
            // 
            // uiIznosNarudzbe
            // 
            this.uiIznosNarudzbe.AutoSize = true;
            this.uiIznosNarudzbe.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiIznosNarudzbe.Location = new System.Drawing.Point(463, 399);
            this.uiIznosNarudzbe.Name = "uiIznosNarudzbe";
            this.uiIznosNarudzbe.Size = new System.Drawing.Size(19, 21);
            this.uiIznosNarudzbe.TabIndex = 83;
            this.uiIznosNarudzbe.Text = "0";
            // 
            // uiNaruci
            // 
            this.uiNaruci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiNaruci.FlatAppearance.BorderSize = 0;
            this.uiNaruci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiNaruci.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiNaruci.Location = new System.Drawing.Point(562, 399);
            this.uiNaruci.Name = "uiNaruci";
            this.uiNaruci.Size = new System.Drawing.Size(88, 24);
            this.uiNaruci.TabIndex = 84;
            this.uiNaruci.Text = "Naruči";
            this.uiNaruci.UseVisualStyleBackColor = false;
            this.uiNaruci.Click += new System.EventHandler(this.uiNaruci_Click);
            // 
            // Jelovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiNaruci);
            this.Controls.Add(this.uiIznosNarudzbe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uiIzbrisiArtikl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiDodajArtikl);
            this.Controls.Add(this.uiNarudzbaContainer);
            this.Controls.Add(this.uiJelovnikContainer);
            this.Controls.Add(this.uiOdabirPonude);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNaslov);
            this.Name = "Jelovnik";
            this.Size = new System.Drawing.Size(711, 441);
            this.Load += new System.EventHandler(this.Jelovnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiJelovnikContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiNarudzbaContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uiOdabirPonude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.DataGridView uiJelovnikContainer;
        private System.Windows.Forms.DataGridView uiNarudzbaContainer;
        private System.Windows.Forms.Button uiDodajArtikl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button uiIzbrisiArtikl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label uiIznosNarudzbe;
        private System.Windows.Forms.Button uiNaruci;
    }
}
