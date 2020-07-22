namespace PrijavaRegistracija.CustomControls
{
    partial class PopisNarudzbi
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
            this.uiContainerNarudzbe = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(28, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 2);
            this.panel1.TabIndex = 64;
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(23, 19);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(109, 28);
            this.uiNaslov.TabIndex = 63;
            this.uiNaslov.Text = "Narudžbe";
            // 
            // uiContainerNarudzbe
            // 
            this.uiContainerNarudzbe.AutoScroll = true;
            this.uiContainerNarudzbe.Location = new System.Drawing.Point(28, 79);
            this.uiContainerNarudzbe.Name = "uiContainerNarudzbe";
            this.uiContainerNarudzbe.Size = new System.Drawing.Size(460, 343);
            this.uiContainerNarudzbe.TabIndex = 65;
            // 
            // PopisNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiContainerNarudzbe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.uiNaslov);
            this.Name = "PopisNarudzbi";
            this.Size = new System.Drawing.Size(592, 447);
            this.Load += new System.EventHandler(this.PopisNarudzbi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.FlowLayoutPanel uiContainerNarudzbe;
    }
}
