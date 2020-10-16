namespace Suporte
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.comboSuporte = new System.Windows.Forms.ComboBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblObs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // comboSuporte
            // 
            this.comboSuporte.FormattingEnabled = true;
            this.comboSuporte.Items.AddRange(new object[] {
            "Suporte 01",
            "Suporte 02",
            "Suporte 03",
            "Suporte 04",
            "Suporte 05",
            "Suporte 06",
            "Suporte 07",
            "Suporte 08",
            "Suporte 09",
            "Suporte 10"});
            this.comboSuporte.Location = new System.Drawing.Point(16, 126);
            this.comboSuporte.Margin = new System.Windows.Forms.Padding(4);
            this.comboSuporte.Name = "comboSuporte";
            this.comboSuporte.Size = new System.Drawing.Size(345, 24);
            this.comboSuporte.TabIndex = 0;
            this.comboSuporte.SelectedIndexChanged += new System.EventHandler(this.comboSuporte_SelectedIndexChanged);
            // 
            // picLogo
            // 
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(373, 72);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObs.Location = new System.Drawing.Point(25, 97);
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(322, 25);
            this.lblObs.TabIndex = 2;
            this.lblObs.Text = "Selecione o seu numero de suporte.";
            this.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(373, 170);
            this.Controls.Add(this.lblObs);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.comboSuporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Suporte Ellite Informática";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboSuporte;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblObs;
    }
}

