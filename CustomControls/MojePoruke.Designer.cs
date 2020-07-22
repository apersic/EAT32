namespace PrijavaRegistracija.CustomControls
{
    partial class MojePoruke
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
            this.uiOznakaNaslov = new System.Windows.Forms.Label();
            this.uiContainerPoruke = new System.Windows.Forms.FlowLayoutPanel();
            this.uiControlsNovaPoruka = new System.Windows.Forms.Button();
            this.uiPrimljenePoruke = new System.Windows.Forms.Button();
            this.uiPoslanePoruke = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiOznakaNaslov
            // 
            this.uiOznakaNaslov.AutoSize = true;
            this.uiOznakaNaslov.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uiOznakaNaslov.Location = new System.Drawing.Point(23, 10);
            this.uiOznakaNaslov.Name = "uiOznakaNaslov";
            this.uiOznakaNaslov.Size = new System.Drawing.Size(137, 28);
            this.uiOznakaNaslov.TabIndex = 10;
            this.uiOznakaNaslov.Text = "Moje poruke";
            // 
            // uiContainerPoruke
            // 
            this.uiContainerPoruke.AutoScroll = true;
            this.uiContainerPoruke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uiContainerPoruke.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.uiContainerPoruke.Location = new System.Drawing.Point(28, 96);
            this.uiContainerPoruke.Name = "uiContainerPoruke";
            this.uiContainerPoruke.Size = new System.Drawing.Size(501, 317);
            this.uiContainerPoruke.TabIndex = 9;
            this.uiContainerPoruke.WrapContents = false;
            // 
            // uiControlsNovaPoruka
            // 
            this.uiControlsNovaPoruka.FlatAppearance.BorderSize = 0;
            this.uiControlsNovaPoruka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiControlsNovaPoruka.Font = new System.Drawing.Font("Roboto Slab", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiControlsNovaPoruka.Image = global::PrijavaRegistracija.Properties.Resources.icons8_plus_math_26;
            this.uiControlsNovaPoruka.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiControlsNovaPoruka.Location = new System.Drawing.Point(356, 6);
            this.uiControlsNovaPoruka.Name = "uiControlsNovaPoruka";
            this.uiControlsNovaPoruka.Size = new System.Drawing.Size(173, 36);
            this.uiControlsNovaPoruka.TabIndex = 11;
            this.uiControlsNovaPoruka.Text = "Nova poruka";
            this.uiControlsNovaPoruka.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiControlsNovaPoruka.UseVisualStyleBackColor = true;
            this.uiControlsNovaPoruka.Click += new System.EventHandler(this.uiControlsNovaPoruka_Click);
            // 
            // uiPrimljenePoruke
            // 
            this.uiPrimljenePoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(87)))), ((int)(((byte)(34)))));
            this.uiPrimljenePoruke.FlatAppearance.BorderSize = 0;
            this.uiPrimljenePoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPrimljenePoruke.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiPrimljenePoruke.Location = new System.Drawing.Point(28, 51);
            this.uiPrimljenePoruke.Name = "uiPrimljenePoruke";
            this.uiPrimljenePoruke.Size = new System.Drawing.Size(250, 40);
            this.uiPrimljenePoruke.TabIndex = 1;
            this.uiPrimljenePoruke.Text = "Primljene poruke";
            this.uiPrimljenePoruke.UseVisualStyleBackColor = false;
            this.uiPrimljenePoruke.Click += new System.EventHandler(this.uiPrimljenePoruke_Click);
            // 
            // uiPoslanePoruke
            // 
            this.uiPoslanePoruke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.uiPoslanePoruke.FlatAppearance.BorderSize = 0;
            this.uiPoslanePoruke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uiPoslanePoruke.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.uiPoslanePoruke.ForeColor = System.Drawing.SystemColors.Control;
            this.uiPoslanePoruke.Location = new System.Drawing.Point(279, 51);
            this.uiPoslanePoruke.Name = "uiPoslanePoruke";
            this.uiPoslanePoruke.Size = new System.Drawing.Size(250, 40);
            this.uiPoslanePoruke.TabIndex = 2;
            this.uiPoslanePoruke.Text = "Poslane poruke";
            this.uiPoslanePoruke.UseVisualStyleBackColor = false;
            this.uiPoslanePoruke.Click += new System.EventHandler(this.uiPoslanePoruke_Click);
            // 
            // MojePoruke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uiPoslanePoruke);
            this.Controls.Add(this.uiPrimljenePoruke);
            this.Controls.Add(this.uiControlsNovaPoruka);
            this.Controls.Add(this.uiOznakaNaslov);
            this.Controls.Add(this.uiContainerPoruke);
            this.Name = "MojePoruke";
            this.Size = new System.Drawing.Size(567, 433);
            this.Load += new System.EventHandler(this.MojePoruke_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button uiControlsNovaPoruka;
        private System.Windows.Forms.Label uiOznakaNaslov;
        private System.Windows.Forms.FlowLayoutPanel uiContainerPoruke;
        private System.Windows.Forms.Button uiPrimljenePoruke;
        private System.Windows.Forms.Button uiPoslanePoruke;
    }
}
