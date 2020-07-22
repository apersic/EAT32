namespace PrijavaRegistracija
{
    partial class Notifikacija
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Notifikacija));
            this.uiNavBarContainer = new System.Windows.Forms.Panel();
            this.uiOznakaNaslov = new System.Windows.Forms.Label();
            this.uiZatvori = new System.Windows.Forms.Button();
            this.uiFormBorder = new System.Windows.Forms.Panel();
            this.uiBorder = new System.Windows.Forms.Panel();
            this.uiOznakaInformacija = new System.Windows.Forms.TextBox();
            this.uiSlikaNotifikacije = new System.Windows.Forms.PictureBox();
            this.uiBtnOK = new System.Windows.Forms.Button();
            this.uiNavBarContainer.SuspendLayout();
            this.uiBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSlikaNotifikacije)).BeginInit();
            this.SuspendLayout();
            // 
            // uiNavBarContainer
            // 
            this.uiNavBarContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiNavBarContainer.Controls.Add(this.uiOznakaNaslov);
            this.uiNavBarContainer.Controls.Add(this.uiZatvori);
            this.uiNavBarContainer.Controls.Add(this.uiFormBorder);
            this.uiNavBarContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiNavBarContainer.Location = new System.Drawing.Point(0, 0);
            this.uiNavBarContainer.Name = "uiNavBarContainer";
            this.uiNavBarContainer.Size = new System.Drawing.Size(314, 32);
            this.uiNavBarContainer.TabIndex = 19;
            // 
            // uiOznakaNaslov
            // 
            this.uiOznakaNaslov.AutoSize = true;
            this.uiOznakaNaslov.Font = new System.Drawing.Font("Roboto Slab", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNaslov.ForeColor = System.Drawing.SystemColors.Control;
            this.uiOznakaNaslov.Location = new System.Drawing.Point(6, 8);
            this.uiOznakaNaslov.Name = "uiOznakaNaslov";
            this.uiOznakaNaslov.Size = new System.Drawing.Size(50, 18);
            this.uiOznakaNaslov.TabIndex = 5;
            this.uiOznakaNaslov.Text = "Naslov";
            // 
            // uiZatvori
            // 
            this.uiZatvori.FlatAppearance.BorderSize = 0;
            this.uiZatvori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiZatvori.Image = ((System.Drawing.Image)(resources.GetObject("uiZatvori.Image")));
            this.uiZatvori.Location = new System.Drawing.Point(284, 5);
            this.uiZatvori.Name = "uiZatvori";
            this.uiZatvori.Size = new System.Drawing.Size(22, 22);
            this.uiZatvori.TabIndex = 4;
            this.uiZatvori.UseVisualStyleBackColor = true;
            this.uiZatvori.Click += new System.EventHandler(this.uiZatvori_Click);
            // 
            // uiFormBorder
            // 
            this.uiFormBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiFormBorder.Location = new System.Drawing.Point(0, 32);
            this.uiFormBorder.Name = "uiFormBorder";
            this.uiFormBorder.Size = new System.Drawing.Size(312, 167);
            this.uiFormBorder.TabIndex = 22;
            // 
            // uiBorder
            // 
            this.uiBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiBorder.Controls.Add(this.uiBtnOK);
            this.uiBorder.Controls.Add(this.uiOznakaInformacija);
            this.uiBorder.Controls.Add(this.uiSlikaNotifikacije);
            this.uiBorder.Location = new System.Drawing.Point(0, 32);
            this.uiBorder.Name = "uiBorder";
            this.uiBorder.Size = new System.Drawing.Size(314, 198);
            this.uiBorder.TabIndex = 22;
            // 
            // uiOznakaInformacija
            // 
            this.uiOznakaInformacija.BackColor = System.Drawing.SystemColors.Control;
            this.uiOznakaInformacija.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiOznakaInformacija.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaInformacija.Location = new System.Drawing.Point(35, 88);
            this.uiOznakaInformacija.Multiline = true;
            this.uiOznakaInformacija.Name = "uiOznakaInformacija";
            this.uiOznakaInformacija.Size = new System.Drawing.Size(240, 40);
            this.uiOznakaInformacija.TabIndex = 23;
            this.uiOznakaInformacija.Text = "Informacija";
            this.uiOznakaInformacija.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // uiSlikaNotifikacije
            // 
            this.uiSlikaNotifikacije.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.uiSlikaNotifikacije.Location = new System.Drawing.Point(125, 18);
            this.uiSlikaNotifikacije.Name = "uiSlikaNotifikacije";
            this.uiSlikaNotifikacije.Size = new System.Drawing.Size(60, 60);
            this.uiSlikaNotifikacije.TabIndex = 22;
            this.uiSlikaNotifikacije.TabStop = false;
            // 
            // uiBtnOK
            // 
            this.uiBtnOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.uiBtnOK.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiBtnOK.Location = new System.Drawing.Point(106, 144);
            this.uiBtnOK.Name = "uiBtnOK";
            this.uiBtnOK.Size = new System.Drawing.Size(99, 31);
            this.uiBtnOK.TabIndex = 24;
            this.uiBtnOK.Text = "OK";
            this.uiBtnOK.UseVisualStyleBackColor = true;
            this.uiBtnOK.Click += new System.EventHandler(this.uiBtnOK_Click);
            // 
            // Notifikacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 230);
            this.Controls.Add(this.uiBorder);
            this.Controls.Add(this.uiNavBarContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notifikacija";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifikacija";
            this.uiNavBarContainer.ResumeLayout(false);
            this.uiNavBarContainer.PerformLayout();
            this.uiBorder.ResumeLayout(false);
            this.uiBorder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiSlikaNotifikacije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel uiNavBarContainer;
        private System.Windows.Forms.Label uiOznakaNaslov;
        private System.Windows.Forms.Button uiZatvori;
        private System.Windows.Forms.Panel uiFormBorder;
        private System.Windows.Forms.Panel uiBorder;
        private System.Windows.Forms.TextBox uiOznakaInformacija;
        private System.Windows.Forms.PictureBox uiSlikaNotifikacije;
        private System.Windows.Forms.Button uiBtnOK;
    }
}