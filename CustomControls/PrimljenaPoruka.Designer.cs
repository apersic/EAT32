namespace PrijavaRegistracija.CustomControls
{
    partial class PrimljenaPoruka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrimljenaPoruka));
            this.uiOznakaPosiljatelj = new System.Windows.Forms.Label();
            this.uiBtnIzbrisi = new System.Windows.Forms.Button();
            this.uiBtnOdgovori = new System.Windows.Forms.Button();
            this.uiSadrzajPoruke = new System.Windows.Forms.TextBox();
            this.uiNaslovPoruke = new System.Windows.Forms.Label();
            this.uiContainerNaslov = new System.Windows.Forms.Panel();
            this.uiDropdown = new System.Windows.Forms.PictureBox();
            this.uiContainerNaslov.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiDropdown)).BeginInit();
            this.SuspendLayout();
            // 
            // uiOznakaPosiljatelj
            // 
            this.uiOznakaPosiljatelj.AutoSize = true;
            this.uiOznakaPosiljatelj.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaPosiljatelj.Location = new System.Drawing.Point(12, 16);
            this.uiOznakaPosiljatelj.Name = "uiOznakaPosiljatelj";
            this.uiOznakaPosiljatelj.Size = new System.Drawing.Size(84, 21);
            this.uiOznakaPosiljatelj.TabIndex = 0;
            this.uiOznakaPosiljatelj.Text = "Posiljatelj";
            // 
            // uiBtnIzbrisi
            // 
            this.uiBtnIzbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtnIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnIzbrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.uiBtnIzbrisi.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnIzbrisi.Image")));
            this.uiBtnIzbrisi.Location = new System.Drawing.Point(455, 14);
            this.uiBtnIzbrisi.Name = "uiBtnIzbrisi";
            this.uiBtnIzbrisi.Size = new System.Drawing.Size(24, 24);
            this.uiBtnIzbrisi.TabIndex = 3;
            this.uiBtnIzbrisi.UseVisualStyleBackColor = true;
            this.uiBtnIzbrisi.Click += new System.EventHandler(this.uiBtnIzbrisi_Click);
            // 
            // uiBtnOdgovori
            // 
            this.uiBtnOdgovori.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiBtnOdgovori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiBtnOdgovori.ForeColor = System.Drawing.SystemColors.Control;
            this.uiBtnOdgovori.Image = ((System.Drawing.Image)(resources.GetObject("uiBtnOdgovori.Image")));
            this.uiBtnOdgovori.Location = new System.Drawing.Point(425, 14);
            this.uiBtnOdgovori.Name = "uiBtnOdgovori";
            this.uiBtnOdgovori.Size = new System.Drawing.Size(24, 24);
            this.uiBtnOdgovori.TabIndex = 2;
            this.uiBtnOdgovori.UseVisualStyleBackColor = true;
            this.uiBtnOdgovori.Click += new System.EventHandler(this.uiBtnOdgovori_Click);
            // 
            // uiSadrzajPoruke
            // 
            this.uiSadrzajPoruke.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiSadrzajPoruke.Location = new System.Drawing.Point(149, 43);
            this.uiSadrzajPoruke.Multiline = true;
            this.uiSadrzajPoruke.Name = "uiSadrzajPoruke";
            this.uiSadrzajPoruke.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uiSadrzajPoruke.Size = new System.Drawing.Size(264, 63);
            this.uiSadrzajPoruke.TabIndex = 4;
            this.uiSadrzajPoruke.Visible = false;
            // 
            // uiNaslovPoruke
            // 
            this.uiNaslovPoruke.AutoSize = true;
            this.uiNaslovPoruke.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslovPoruke.Location = new System.Drawing.Point(150, 15);
            this.uiNaslovPoruke.Name = "uiNaslovPoruke";
            this.uiNaslovPoruke.Size = new System.Drawing.Size(68, 21);
            this.uiNaslovPoruke.TabIndex = 5;
            this.uiNaslovPoruke.Text = "Naslov";
            // 
            // uiContainerNaslov
            // 
            this.uiContainerNaslov.Controls.Add(this.uiDropdown);
            this.uiContainerNaslov.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiContainerNaslov.Location = new System.Drawing.Point(149, 14);
            this.uiContainerNaslov.Name = "uiContainerNaslov";
            this.uiContainerNaslov.Size = new System.Drawing.Size(264, 24);
            this.uiContainerNaslov.TabIndex = 6;
            this.uiContainerNaslov.Click += new System.EventHandler(this.uiContainerNaslov_Click);
            // 
            // uiDropdown
            // 
            this.uiDropdown.Image = ((System.Drawing.Image)(resources.GetObject("uiDropdown.Image")));
            this.uiDropdown.Location = new System.Drawing.Point(239, 0);
            this.uiDropdown.Name = "uiDropdown";
            this.uiDropdown.Size = new System.Drawing.Size(24, 24);
            this.uiDropdown.TabIndex = 0;
            this.uiDropdown.TabStop = false;
            this.uiDropdown.Click += new System.EventHandler(this.uiDropdown_Click);
            // 
            // PrimljenaPoruka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiNaslovPoruke);
            this.Controls.Add(this.uiSadrzajPoruke);
            this.Controls.Add(this.uiBtnIzbrisi);
            this.Controls.Add(this.uiBtnOdgovori);
            this.Controls.Add(this.uiOznakaPosiljatelj);
            this.Controls.Add(this.uiContainerNaslov);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "PrimljenaPoruka";
            this.Size = new System.Drawing.Size(499, 51);
            this.uiContainerNaslov.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiDropdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiOznakaPosiljatelj;
        private System.Windows.Forms.Button uiBtnOdgovori;
        private System.Windows.Forms.Button uiBtnIzbrisi;
        private System.Windows.Forms.TextBox uiSadrzajPoruke;
        private System.Windows.Forms.Label uiNaslovPoruke;
        private System.Windows.Forms.Panel uiContainerNaslov;
        private System.Windows.Forms.PictureBox uiDropdown;
    }
}
