namespace PrijavaRegistracija
{
    partial class KorisnikGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KorisnikGlavna));
            this.uiOznakaNaslov = new System.Windows.Forms.Label();
            this.uiContainerSideBar = new System.Windows.Forms.Panel();
            this.uiOpenHelper = new System.Windows.Forms.Button();
            this.uiMojProfil = new System.Windows.Forms.Button();
            this.uiMojeNarudzbe = new System.Windows.Forms.Button();
            this.uiPomicniPanel = new System.Windows.Forms.Panel();
            this.uiPoruke = new System.Windows.Forms.Button();
            this.uiNovosti = new System.Windows.Forms.Button();
            this.uiContainerSection = new System.Windows.Forms.FlowLayoutPanel();
            this.uiZatvoriProzor = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.uiContainerSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiOznakaNaslov
            // 
            this.uiOznakaNaslov.AutoSize = true;
            this.uiOznakaNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiOznakaNaslov.Location = new System.Drawing.Point(12, 21);
            this.uiOznakaNaslov.Name = "uiOznakaNaslov";
            this.uiOznakaNaslov.Size = new System.Drawing.Size(100, 20);
            this.uiOznakaNaslov.TabIndex = 0;
            this.uiOznakaNaslov.Text = "Pretrazivanje";
            // 
            // uiContainerSideBar
            // 
            this.uiContainerSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiContainerSideBar.Controls.Add(this.uiOpenHelper);
            this.uiContainerSideBar.Controls.Add(this.uiMojProfil);
            this.uiContainerSideBar.Controls.Add(this.uiMojeNarudzbe);
            this.uiContainerSideBar.Controls.Add(this.uiPomicniPanel);
            this.uiContainerSideBar.Controls.Add(this.uiPoruke);
            this.uiContainerSideBar.Controls.Add(this.uiNovosti);
            this.uiContainerSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.uiContainerSideBar.Location = new System.Drawing.Point(0, 0);
            this.uiContainerSideBar.Name = "uiContainerSideBar";
            this.uiContainerSideBar.Size = new System.Drawing.Size(143, 499);
            this.uiContainerSideBar.TabIndex = 6;
            // 
            // uiOpenHelper
            // 
            this.uiOpenHelper.FlatAppearance.BorderSize = 0;
            this.uiOpenHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiOpenHelper.Image = global::PrijavaRegistracija.Properties.Resources.icons8_ask_question_32_1_;
            this.uiOpenHelper.Location = new System.Drawing.Point(12, 455);
            this.uiOpenHelper.Name = "uiOpenHelper";
            this.uiOpenHelper.Size = new System.Drawing.Size(32, 32);
            this.uiOpenHelper.TabIndex = 15;
            this.uiOpenHelper.UseVisualStyleBackColor = true;
            this.uiOpenHelper.Click += new System.EventHandler(this.uiOpenHelper_Click);
            // 
            // uiMojProfil
            // 
            this.uiMojProfil.FlatAppearance.BorderSize = 0;
            this.uiMojProfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiMojProfil.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiMojProfil.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiMojProfil.Image = global::PrijavaRegistracija.Properties.Resources.icons8_contacts_32;
            this.uiMojProfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMojProfil.Location = new System.Drawing.Point(3, 262);
            this.uiMojProfil.Name = "uiMojProfil";
            this.uiMojProfil.Size = new System.Drawing.Size(123, 68);
            this.uiMojProfil.TabIndex = 14;
            this.uiMojProfil.Text = "Moj Profil";
            this.uiMojProfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMojProfil.UseVisualStyleBackColor = true;
            this.uiMojProfil.Click += new System.EventHandler(this.uiMojProfil_Click);
            // 
            // uiMojeNarudzbe
            // 
            this.uiMojeNarudzbe.FlatAppearance.BorderSize = 0;
            this.uiMojeNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiMojeNarudzbe.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiMojeNarudzbe.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiMojeNarudzbe.Image = global::PrijavaRegistracija.Properties.Resources.icons8_purchase_order_24;
            this.uiMojeNarudzbe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiMojeNarudzbe.Location = new System.Drawing.Point(3, 188);
            this.uiMojeNarudzbe.Name = "uiMojeNarudzbe";
            this.uiMojeNarudzbe.Size = new System.Drawing.Size(123, 68);
            this.uiMojeNarudzbe.TabIndex = 13;
            this.uiMojeNarudzbe.Text = "Moje        Narudžbe";
            this.uiMojeNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiMojeNarudzbe.UseVisualStyleBackColor = true;
            this.uiMojeNarudzbe.Click += new System.EventHandler(this.uiMojeNarudzbe_Click);
            // 
            // uiPomicniPanel
            // 
            this.uiPomicniPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiPomicniPanel.Location = new System.Drawing.Point(132, 52);
            this.uiPomicniPanel.Name = "uiPomicniPanel";
            this.uiPomicniPanel.Size = new System.Drawing.Size(10, 68);
            this.uiPomicniPanel.TabIndex = 12;
            // 
            // uiPoruke
            // 
            this.uiPoruke.FlatAppearance.BorderSize = 0;
            this.uiPoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPoruke.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiPoruke.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiPoruke.Image = global::PrijavaRegistracija.Properties.Resources.icons8_chat_26;
            this.uiPoruke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiPoruke.Location = new System.Drawing.Point(3, 114);
            this.uiPoruke.Name = "uiPoruke";
            this.uiPoruke.Size = new System.Drawing.Size(123, 68);
            this.uiPoruke.TabIndex = 11;
            this.uiPoruke.Text = "Poruke";
            this.uiPoruke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiPoruke.UseVisualStyleBackColor = true;
            this.uiPoruke.Click += new System.EventHandler(this.uiPoruke_Click);
            // 
            // uiNovosti
            // 
            this.uiNovosti.FlatAppearance.BorderSize = 0;
            this.uiNovosti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiNovosti.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiNovosti.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.uiNovosti.Image = global::PrijavaRegistracija.Properties.Resources.icons8_news_26;
            this.uiNovosti.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiNovosti.Location = new System.Drawing.Point(3, 52);
            this.uiNovosti.Name = "uiNovosti";
            this.uiNovosti.Size = new System.Drawing.Size(123, 68);
            this.uiNovosti.TabIndex = 10;
            this.uiNovosti.Text = "Novosti";
            this.uiNovosti.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiNovosti.UseVisualStyleBackColor = true;
            this.uiNovosti.Click += new System.EventHandler(this.uiNovosti_Click);
            // 
            // uiContainerSection
            // 
            this.uiContainerSection.Location = new System.Drawing.Point(151, 52);
            this.uiContainerSection.Name = "uiContainerSection";
            this.uiContainerSection.Size = new System.Drawing.Size(617, 447);
            this.uiContainerSection.TabIndex = 9;
            // 
            // uiZatvoriProzor
            // 
            this.uiZatvoriProzor.FlatAppearance.BorderSize = 0;
            this.uiZatvoriProzor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiZatvoriProzor.Image = ((System.Drawing.Image)(resources.GetObject("uiZatvoriProzor.Image")));
            this.uiZatvoriProzor.Location = new System.Drawing.Point(746, 12);
            this.uiZatvoriProzor.Name = "uiZatvoriProzor";
            this.uiZatvoriProzor.Size = new System.Drawing.Size(22, 22);
            this.uiZatvoriProzor.TabIndex = 5;
            this.uiZatvoriProzor.UseVisualStyleBackColor = true;
            this.uiZatvoriProzor.Click += new System.EventHandler(this.uiZatvoriProzor_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "..\\..\\Dokumentacija\\EAT32Helper.chm";
            // 
            // KorisnikGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 499);
            this.Controls.Add(this.uiContainerSideBar);
            this.Controls.Add(this.uiZatvoriProzor);
            this.Controls.Add(this.uiOznakaNaslov);
            this.Controls.Add(this.uiContainerSection);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.helpProvider.SetHelpKeyword(this, "KorisnikGlavna");
            this.Name = "KorisnikGlavna";
            this.helpProvider.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.KorisnikGlavna_Load);
            this.uiContainerSideBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label uiOznakaNaslov;
        private System.Windows.Forms.Button uiZatvoriProzor;
        private System.Windows.Forms.Panel uiContainerSideBar;
        private System.Windows.Forms.FlowLayoutPanel uiContainerSection;
        private System.Windows.Forms.Button uiNovosti;
        private System.Windows.Forms.Button uiPoruke;
        private System.Windows.Forms.Panel uiPomicniPanel;
        private System.Windows.Forms.Button uiMojProfil;
        private System.Windows.Forms.Button uiMojeNarudzbe;
        private System.Windows.Forms.Button uiOpenHelper;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}