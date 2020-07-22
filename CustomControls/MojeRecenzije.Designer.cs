namespace PrijavaRegistracija.CustomControls
{
    partial class MojeRecenzije
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.uiNaslov = new System.Windows.Forms.Label();
            this.uiContainerRecenzije = new System.Windows.Forms.FlowLayoutPanel();
            this.uiOznakaProsjecnaOcjena = new System.Windows.Forms.Label();
            this.uiSlikaZvjezdice = new System.Windows.Forms.PictureBox();
            this.uiProsjecnaOcjena = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.uiSlikaZvjezdice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(32, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 69;
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(27, 23);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(249, 28);
            this.uiNaslov.TabIndex = 68;
            this.uiNaslov.Text = "Recenzije na moj objekt";
            // 
            // uiContainerRecenzije
            // 
            this.uiContainerRecenzije.Location = new System.Drawing.Point(32, 84);
            this.uiContainerRecenzije.Name = "uiContainerRecenzije";
            this.uiContainerRecenzije.Size = new System.Drawing.Size(460, 282);
            this.uiContainerRecenzije.TabIndex = 70;
            // 
            // uiOznakaProsjecnaOcjena
            // 
            this.uiOznakaProsjecnaOcjena.AutoSize = true;
            this.uiOznakaProsjecnaOcjena.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaProsjecnaOcjena.Location = new System.Drawing.Point(226, 379);
            this.uiOznakaProsjecnaOcjena.Name = "uiOznakaProsjecnaOcjena";
            this.uiOznakaProsjecnaOcjena.Size = new System.Drawing.Size(221, 25);
            this.uiOznakaProsjecnaOcjena.TabIndex = 71;
            this.uiOznakaProsjecnaOcjena.Text = "Moja prosjecna ocjena: ";
            // 
            // uiSlikaZvjezdice
            // 
            this.uiSlikaZvjezdice.Image = global::PrijavaRegistracija.Properties.Resources.icons8_christmas_star_32;
            this.uiSlikaZvjezdice.Location = new System.Drawing.Point(460, 376);
            this.uiSlikaZvjezdice.Name = "uiSlikaZvjezdice";
            this.uiSlikaZvjezdice.Size = new System.Drawing.Size(32, 32);
            this.uiSlikaZvjezdice.TabIndex = 72;
            this.uiSlikaZvjezdice.TabStop = false;
            // 
            // uiProsjecnaOcjena
            // 
            this.uiProsjecnaOcjena.AutoSize = true;
            this.uiProsjecnaOcjena.Font = new System.Drawing.Font("Roboto Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiProsjecnaOcjena.Location = new System.Drawing.Point(438, 379);
            this.uiProsjecnaOcjena.Margin = new System.Windows.Forms.Padding(0);
            this.uiProsjecnaOcjena.Name = "uiProsjecnaOcjena";
            this.uiProsjecnaOcjena.Size = new System.Drawing.Size(0, 25);
            this.uiProsjecnaOcjena.TabIndex = 73;
            // 
            // MojeRecenzije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiProsjecnaOcjena);
            this.Controls.Add(this.uiSlikaZvjezdice);
            this.Controls.Add(this.uiOznakaProsjecnaOcjena);
            this.Controls.Add(this.uiContainerRecenzije);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNaslov);
            this.Name = "MojeRecenzije";
            this.Size = new System.Drawing.Size(567, 433);
            this.Load += new System.EventHandler(this.MojeRecenzije_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uiSlikaZvjezdice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.FlowLayoutPanel uiContainerRecenzije;
        private System.Windows.Forms.Label uiOznakaProsjecnaOcjena;
        private System.Windows.Forms.PictureBox uiSlikaZvjezdice;
        private System.Windows.Forms.Label uiProsjecnaOcjena;
    }
}
