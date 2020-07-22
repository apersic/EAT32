namespace PrijavaRegistracija.CustomControls
{
    partial class Novosti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Novosti));
            this.uiNaslov = new System.Windows.Forms.Label();
            this.uiPopisObjekataContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.uiUnosPretrazivanje = new System.Windows.Forms.TextBox();
            this.uiContainerPretrazivanje = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.uiOdabirFiltera = new System.Windows.Forms.ComboBox();
            this.uiContainerPretrazivanje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uiNaslov
            // 
            this.uiNaslov.AutoSize = true;
            this.uiNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiNaslov.Location = new System.Drawing.Point(23, 15);
            this.uiNaslov.Name = "uiNaslov";
            this.uiNaslov.Size = new System.Drawing.Size(84, 25);
            this.uiNaslov.TabIndex = 11;
            this.uiNaslov.Text = "Novosti";
            // 
            // uiPopisObjekataContainer
            // 
            this.uiPopisObjekataContainer.AutoScroll = true;
            this.uiPopisObjekataContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uiPopisObjekataContainer.Location = new System.Drawing.Point(28, 53);
            this.uiPopisObjekataContainer.Name = "uiPopisObjekataContainer";
            this.uiPopisObjekataContainer.Size = new System.Drawing.Size(565, 393);
            this.uiPopisObjekataContainer.TabIndex = 9;
            this.uiPopisObjekataContainer.WrapContents = false;
            // 
            // uiUnosPretrazivanje
            // 
            this.uiUnosPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiUnosPretrazivanje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiUnosPretrazivanje.Location = new System.Drawing.Point(5, 5);
            this.uiUnosPretrazivanje.Multiline = true;
            this.uiUnosPretrazivanje.Name = "uiUnosPretrazivanje";
            this.uiUnosPretrazivanje.Size = new System.Drawing.Size(164, 24);
            this.uiUnosPretrazivanje.TabIndex = 3;
            this.uiUnosPretrazivanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.uiUnosPretrazivanje.TextChanged += new System.EventHandler(this.uiUnosPretrazivanje_TextChanged);
            // 
            // uiContainerPretrazivanje
            // 
            this.uiContainerPretrazivanje.BackColor = System.Drawing.SystemColors.Window;
            this.uiContainerPretrazivanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiContainerPretrazivanje.Controls.Add(this.pictureBox1);
            this.uiContainerPretrazivanje.Controls.Add(this.uiUnosPretrazivanje);
            this.uiContainerPretrazivanje.Location = new System.Drawing.Point(393, 10);
            this.uiContainerPretrazivanje.Name = "uiContainerPretrazivanje";
            this.uiContainerPretrazivanje.Size = new System.Drawing.Size(200, 34);
            this.uiContainerPretrazivanje.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // uiOdabirFiltera
            // 
            this.uiOdabirFiltera.Font = new System.Drawing.Font("Roboto Slab", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOdabirFiltera.FormattingEnabled = true;
            this.uiOdabirFiltera.Items.AddRange(new object[] {
            "Bez filtera",
            "Prikaži samo otvorene objekte",
            "Prikaži najbolje ocijenjene objekte"});
            this.uiOdabirFiltera.Location = new System.Drawing.Point(162, 11);
            this.uiOdabirFiltera.Name = "uiOdabirFiltera";
            this.uiOdabirFiltera.Size = new System.Drawing.Size(223, 28);
            this.uiOdabirFiltera.TabIndex = 12;
            this.uiOdabirFiltera.SelectedValueChanged += new System.EventHandler(this.uiOdabirFiltera_SelectedValueChanged);
            // 
            // Novosti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiOdabirFiltera);
            this.Controls.Add(this.uiNaslov);
            this.Controls.Add(this.uiPopisObjekataContainer);
            this.Controls.Add(this.uiContainerPretrazivanje);
            this.Name = "Novosti";
            this.Size = new System.Drawing.Size(617, 455);
            this.uiContainerPretrazivanje.ResumeLayout(false);
            this.uiContainerPretrazivanje.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uiNaslov;
        private System.Windows.Forms.FlowLayoutPanel uiPopisObjekataContainer;
        private System.Windows.Forms.TextBox uiUnosPretrazivanje;
        private System.Windows.Forms.Panel uiContainerPretrazivanje;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox uiOdabirFiltera;
    }
}
