
namespace AppEditImage.Controllers
{
    partial class LightColor
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
            this.txbBrightness = new System.Windows.Forms.TextBox();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.lbLight = new System.Windows.Forms.Label();
            this.txbContrast = new System.Windows.Forms.TextBox();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.lbContrast = new System.Windows.Forms.Label();
            this.lbBrightness = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnContrast = new System.Windows.Forms.Button();
            this.btnBrightness = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBrightness
            // 
            this.txbBrightness.BackColor = System.Drawing.Color.Black;
            this.txbBrightness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBrightness.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbBrightness.ForeColor = System.Drawing.Color.White;
            this.txbBrightness.Location = new System.Drawing.Point(229, 69);
            this.txbBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbBrightness.MaxLength = 4;
            this.txbBrightness.Name = "txbBrightness";
            this.txbBrightness.Size = new System.Drawing.Size(43, 20);
            this.txbBrightness.TabIndex = 4;
            this.txbBrightness.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbBrightness.TextChanged += new System.EventHandler(this.txbBrightness_TextChanged);
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.AutoSize = false;
            this.trackBarBrightness.Location = new System.Drawing.Point(5, 105);
            this.trackBarBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Minimum = -100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(267, 25);
            this.trackBarBrightness.TabIndex = 2;
            this.trackBarBrightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarBrightness.Scroll += new System.EventHandler(this.trackBarBrightness_Scroll);
            this.trackBarBrightness.ValueChanged += new System.EventHandler(this.trackBarBrightness_ValueChanged);
            this.trackBarBrightness.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarBrightness_MouseUp);
            // 
            // lbLight
            // 
            this.lbLight.AutoSize = true;
            this.lbLight.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbLight.ForeColor = System.Drawing.Color.White;
            this.lbLight.Location = new System.Drawing.Point(32, 21);
            this.lbLight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLight.Name = "lbLight";
            this.lbLight.Size = new System.Drawing.Size(66, 27);
            this.lbLight.TabIndex = 1;
            this.lbLight.Text = "LIGHT";
            // 
            // txbContrast
            // 
            this.txbContrast.BackColor = System.Drawing.Color.Black;
            this.txbContrast.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbContrast.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbContrast.ForeColor = System.Drawing.Color.White;
            this.txbContrast.Location = new System.Drawing.Point(229, 143);
            this.txbContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txbContrast.MaxLength = 4;
            this.txbContrast.Name = "txbContrast";
            this.txbContrast.Size = new System.Drawing.Size(43, 20);
            this.txbContrast.TabIndex = 10;
            this.txbContrast.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbContrast.TextChanged += new System.EventHandler(this.txbContrast_TextChanged);
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.AutoSize = false;
            this.trackBarContrast.Location = new System.Drawing.Point(5, 178);
            this.trackBarContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.trackBarContrast.Maximum = 100;
            this.trackBarContrast.Minimum = -100;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(267, 25);
            this.trackBarContrast.TabIndex = 8;
            this.trackBarContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarContrast.ValueChanged += new System.EventHandler(this.trackBarContrast_ValueChanged);
            this.trackBarContrast.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarContrast_MouseUp);
            // 
            // lbContrast
            // 
            this.lbContrast.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbContrast.ForeColor = System.Drawing.Color.White;
            this.lbContrast.Image = global::AppEditImage.Properties.Resources.icons8_contrast_24;
            this.lbContrast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbContrast.Location = new System.Drawing.Point(9, 140);
            this.lbContrast.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbContrast.Name = "lbContrast";
            this.lbContrast.Size = new System.Drawing.Size(133, 28);
            this.lbContrast.TabIndex = 9;
            this.lbContrast.Text = "          Contrast";
            this.lbContrast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBrightness
            // 
            this.lbBrightness.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbBrightness.ForeColor = System.Drawing.Color.White;
            this.lbBrightness.Image = global::AppEditImage.Properties.Resources.icons8_sun_24;
            this.lbBrightness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbBrightness.Location = new System.Drawing.Point(9, 66);
            this.lbBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.lbBrightness.Name = "lbBrightness";
            this.lbBrightness.Size = new System.Drawing.Size(133, 28);
            this.lbBrightness.TabIndex = 3;
            this.lbBrightness.Text = "          Brightness";
            this.lbBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnContrast);
            this.panel1.Controls.Add(this.btnBrightness);
            this.panel1.Controls.Add(this.lbLight);
            this.panel1.Controls.Add(this.txbBrightness);
            this.panel1.Controls.Add(this.txbContrast);
            this.panel1.Controls.Add(this.lbBrightness);
            this.panel1.Controls.Add(this.lbContrast);
            this.panel1.Controls.Add(this.trackBarContrast);
            this.panel1.Controls.Add(this.trackBarBrightness);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 838);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnContrast
            // 
            this.btnContrast.FlatAppearance.BorderSize = 0;
            this.btnContrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContrast.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnContrast.ForeColor = System.Drawing.Color.White;
            this.btnContrast.Image = global::AppEditImage.Properties.Resources.icons8_contrast_24;
            this.btnContrast.Location = new System.Drawing.Point(148, 274);
            this.btnContrast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContrast.Name = "btnContrast";
            this.btnContrast.Size = new System.Drawing.Size(140, 92);
            this.btnContrast.TabIndex = 12;
            this.btnContrast.Text = "Contrast";
            this.btnContrast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnContrast.UseVisualStyleBackColor = true;
            // 
            // btnBrightness
            // 
            this.btnBrightness.FlatAppearance.BorderSize = 0;
            this.btnBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrightness.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBrightness.ForeColor = System.Drawing.Color.White;
            this.btnBrightness.Image = global::AppEditImage.Properties.Resources.icons8_sun_24;
            this.btnBrightness.Location = new System.Drawing.Point(13, 274);
            this.btnBrightness.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrightness.Name = "btnBrightness";
            this.btnBrightness.Size = new System.Drawing.Size(140, 92);
            this.btnBrightness.TabIndex = 11;
            this.btnBrightness.Text = "Brightness";
            this.btnBrightness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBrightness.UseVisualStyleBackColor = true;
            this.btnBrightness.Click += new System.EventHandler(this.btnBrightness_Click);
            // 
            // LightColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LightColor";
            this.Size = new System.Drawing.Size(307, 838);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbLight;
        private System.Windows.Forms.Label lbBrightness;
        private System.Windows.Forms.Label lbContrast;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TrackBar trackBarBrightness;
        public System.Windows.Forms.TextBox txbBrightness;
        public System.Windows.Forms.TextBox txbContrast;
        public System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Button btnContrast;
        private System.Windows.Forms.Button btnBrightness;
    }
}
