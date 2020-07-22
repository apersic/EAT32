namespace PrijavaRegistracija
{
    partial class UgostiteljGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UgostiteljGlavna));
            this.uiContainerSideBar = new System.Windows.Forms.Panel();
            this.uiOpenHelper = new System.Windows.Forms.Button();
            this.uiAktivniPanel = new System.Windows.Forms.Panel();
            this.uiSideBarMojeRecenzije = new System.Windows.Forms.Button();
            this.uiSideBarMojePoruke = new System.Windows.Forms.Button();
            this.uiSideBarMojaPonuda = new System.Windows.Forms.Button();
            this.uiSideBarNarudzbe = new System.Windows.Forms.Button();
            this.uiSideBarMojProfil = new System.Windows.Forms.Button();
            this.uiContainerSection = new System.Windows.Forms.FlowLayoutPanel();
            this.uiZatvoriProzor = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.uiContainerSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiContainerSideBar
            // 
            this.uiContainerSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiContainerSideBar.Controls.Add(this.uiOpenHelper);
            this.uiContainerSideBar.Controls.Add(this.uiAktivniPanel);
            this.uiContainerSideBar.Controls.Add(this.uiSideBarMojeRecenzije);
            this.uiContainerSideBar.Controls.Add(this.uiSideBarMojePoruke);
            this.uiContainerSideBar.Controls.Add(this.uiSideBarMojaPonuda);
            this.uiContainerSideBar.Controls.Add(this.uiSideBarNarudzbe);
            this.uiContainerSideBar.Controls.Add(this.uiSideBarMojProfil);
            this.uiContainerSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiContainerSideBar.Location = new System.Drawing.Point(0, 0);
            this.uiContainerSideBar.Name = "uiContainerSideBar";
            this.uiContainerSideBar.Size = new System.Drawing.Size(176, 518);
            this.uiContainerSideBar.TabIndex = 0;
            // 
            // uiOpenHelper
            // 
            this.uiOpenHelper.FlatAppearance.BorderSize = 0;
            this.uiOpenHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOpenHelper.Image = global::PrijavaRegistracija.Properties.Resources.icons8_ask_question_32_1_;
            this.uiOpenHelper.Location = new System.Drawing.Point(12, 474);
            this.uiOpenHelper.Name = "uiOpenHelper";
            this.uiOpenHelper.Size = new System.Drawing.Size(32, 32);
            this.uiOpenHelper.TabIndex = 16;
            this.uiOpenHelper.UseVisualStyleBackColor = true;
            this.uiOpenHelper.Click += new System.EventHandler(this.uiOpenHelper_Click);
            // 
            // uiAktivniPanel
            // 
            this.uiAktivniPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiAktivniPanel.Location = new System.Drawing.Point(161, 90);
            this.uiAktivniPanel.Name = "uiAktivniPanel";
            this.uiAktivniPanel.Size = new System.Drawing.Size(15, 63);
            this.uiAktivniPanel.TabIndex = 8;
            // 
            // uiSideBarMojeRecenzije
            // 
            this.uiSideBarMojeRecenzije.FlatAppearance.BorderSize = 0;
            this.uiSideBarMojeRecenzije.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSideBarMojeRecenzije.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSideBarMojeRecenzije.Image = ((System.Drawing.Image)(resources.GetObject("uiSideBarMojeRecenzije.Image")));
            this.uiSideBarMojeRecenzije.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSideBarMojeRecenzije.Location = new System.Drawing.Point(0, 366);
            this.uiSideBarMojeRecenzije.Name = "uiSideBarMojeRecenzije";
            this.uiSideBarMojeRecenzije.Size = new System.Drawing.Size(165, 63);
            this.uiSideBarMojeRecenzije.TabIndex = 7;
            this.uiSideBarMojeRecenzije.Text = "     Recenzije";
            this.uiSideBarMojeRecenzije.UseVisualStyleBackColor = true;
            this.uiSideBarMojeRecenzije.Click += new System.EventHandler(this.uiSideBarMojeRecenzije_Click);
            // 
            // uiSideBarMojePoruke
            // 
            this.uiSideBarMojePoruke.FlatAppearance.BorderSize = 0;
            this.uiSideBarMojePoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSideBarMojePoruke.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSideBarMojePoruke.Image = ((System.Drawing.Image)(resources.GetObject("uiSideBarMojePoruke.Image")));
            this.uiSideBarMojePoruke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSideBarMojePoruke.Location = new System.Drawing.Point(0, 297);
            this.uiSideBarMojePoruke.Name = "uiSideBarMojePoruke";
            this.uiSideBarMojePoruke.Size = new System.Drawing.Size(165, 63);
            this.uiSideBarMojePoruke.TabIndex = 6;
            this.uiSideBarMojePoruke.Text = "    Poruke";
            this.uiSideBarMojePoruke.UseVisualStyleBackColor = true;
            this.uiSideBarMojePoruke.Click += new System.EventHandler(this.uiSideBarMojePoruke_Click);
            // 
            // uiSideBarMojaPonuda
            // 
            this.uiSideBarMojaPonuda.FlatAppearance.BorderSize = 0;
            this.uiSideBarMojaPonuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSideBarMojaPonuda.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSideBarMojaPonuda.Image = ((System.Drawing.Image)(resources.GetObject("uiSideBarMojaPonuda.Image")));
            this.uiSideBarMojaPonuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSideBarMojaPonuda.Location = new System.Drawing.Point(0, 228);
            this.uiSideBarMojaPonuda.Name = "uiSideBarMojaPonuda";
            this.uiSideBarMojaPonuda.Size = new System.Drawing.Size(165, 63);
            this.uiSideBarMojaPonuda.TabIndex = 5;
            this.uiSideBarMojaPonuda.Text = "    Ponuda";
            this.uiSideBarMojaPonuda.UseVisualStyleBackColor = true;
            this.uiSideBarMojaPonuda.Click += new System.EventHandler(this.uiSideBarMojaPonuda_Click);
            // 
            // uiSideBarNarudzbe
            // 
            this.uiSideBarNarudzbe.FlatAppearance.BorderSize = 0;
            this.uiSideBarNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSideBarNarudzbe.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSideBarNarudzbe.Image = ((System.Drawing.Image)(resources.GetObject("uiSideBarNarudzbe.Image")));
            this.uiSideBarNarudzbe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSideBarNarudzbe.Location = new System.Drawing.Point(0, 159);
            this.uiSideBarNarudzbe.Name = "uiSideBarNarudzbe";
            this.uiSideBarNarudzbe.Size = new System.Drawing.Size(165, 63);
            this.uiSideBarNarudzbe.TabIndex = 4;
            this.uiSideBarNarudzbe.Text = "     Narudžbe";
            this.uiSideBarNarudzbe.UseVisualStyleBackColor = true;
            this.uiSideBarNarudzbe.Click += new System.EventHandler(this.uiSideBarNarudzbe_Click);
            // 
            // uiSideBarMojProfil
            // 
            this.uiSideBarMojProfil.FlatAppearance.BorderSize = 0;
            this.uiSideBarMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiSideBarMojProfil.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSideBarMojProfil.Image = ((System.Drawing.Image)(resources.GetObject("uiSideBarMojProfil.Image")));
            this.uiSideBarMojProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiSideBarMojProfil.Location = new System.Drawing.Point(0, 90);
            this.uiSideBarMojProfil.Name = "uiSideBarMojProfil";
            this.uiSideBarMojProfil.Size = new System.Drawing.Size(160, 63);
            this.uiSideBarMojProfil.TabIndex = 3;
            this.uiSideBarMojProfil.Text = "      Moj profil";
            this.uiSideBarMojProfil.UseVisualStyleBackColor = true;
            this.uiSideBarMojProfil.Click += new System.EventHandler(this.uiSideBarMojProfil_Click);
            // 
            // uiContainerSection
            // 
            this.helpProvider.SetHelpKeyword(this.uiContainerSection, "UgostiteljGlavna");
            this.uiContainerSection.Location = new System.Drawing.Point(191, 52);
            this.uiContainerSection.Name = "uiContainerSection";
            this.helpProvider.SetShowHelp(this.uiContainerSection, true);
            this.uiContainerSection.Size = new System.Drawing.Size(592, 454);
            this.uiContainerSection.TabIndex = 10;
            // 
            // uiZatvoriProzor
            // 
            this.uiZatvoriProzor.FlatAppearance.BorderSize = 0;
            this.uiZatvoriProzor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiZatvoriProzor.Image = ((System.Drawing.Image)(resources.GetObject("uiZatvoriProzor.Image")));
            this.uiZatvoriProzor.Location = new System.Drawing.Point(761, 12);
            this.uiZatvoriProzor.Name = "uiZatvoriProzor";
            this.uiZatvoriProzor.Size = new System.Drawing.Size(22, 22);
            this.uiZatvoriProzor.TabIndex = 6;
            this.uiZatvoriProzor.UseVisualStyleBackColor = true;
            this.uiZatvoriProzor.Click += new System.EventHandler(this.uiZatvoriProzor_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "..\\..\\Dokumentacija\\EAT32Helper.chm";
            // 
            // UgostiteljGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 518);
            this.Controls.Add(this.uiZatvoriProzor);
            this.Controls.Add(this.uiContainerSideBar);
            this.Controls.Add(this.uiContainerSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UgostiteljGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.UgostiteljGlavna_Load);
            this.uiContainerSideBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel uiContainerSideBar;
        private System.Windows.Forms.Button uiZatvoriProzor;
        private System.Windows.Forms.FlowLayoutPanel uiContainerSection;
        private System.Windows.Forms.Button uiSideBarMojProfil;
        private System.Windows.Forms.Button uiSideBarNarudzbe;
        private System.Windows.Forms.Button uiSideBarMojeRecenzije;
        private System.Windows.Forms.Button uiSideBarMojePoruke;
        private System.Windows.Forms.Button uiSideBarMojaPonuda;
        private System.Windows.Forms.Panel uiAktivniPanel;
        private System.Windows.Forms.Button uiOpenHelper;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}