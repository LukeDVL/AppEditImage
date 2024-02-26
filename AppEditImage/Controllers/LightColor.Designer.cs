
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
            this.txbShadow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarShadow = new System.Windows.Forms.TrackBar();
            this.txbHighlight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarHighlight = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighlight)).BeginInit();
            this.SuspendLayout();
            // 
            // txbBrightness
            // 
            this.txbBrightness.BackColor = System.Drawing.Color.Black;
            this.txbBrightness.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbBrightness.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbBrightness.ForeColor = System.Drawing.Color.White;
            this.txbBrightness.Location = new System.Drawing.Point(229, 69);
            this.txbBrightness.Margin = new System.Windows.Forms.Padding(4);
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
            this.txbContrast.Margin = new System.Windows.Forms.Padding(4);
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
            this.panel1.Controls.Add(this.txbShadow);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackBarShadow);
            this.panel1.Controls.Add(this.txbHighlight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.trackBarHighlight);
            this.panel1.Controls.Add(this.lbLight);
            this.panel1.Controls.Add(this.txbBrightness);
            this.panel1.Controls.Add(this.txbContrast);
            this.panel1.Controls.Add(this.lbBrightness);
            this.panel1.Controls.Add(this.lbContrast);
            this.panel1.Controls.Add(this.trackBarContrast);
            this.panel1.Controls.Add(this.trackBarBrightness);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(307, 838);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txbShadow
            // 
            this.txbShadow.BackColor = System.Drawing.Color.Black;
            this.txbShadow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbShadow.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbShadow.ForeColor = System.Drawing.Color.White;
            this.txbShadow.Location = new System.Drawing.Point(229, 291);
            this.txbShadow.Margin = new System.Windows.Forms.Padding(4);
            this.txbShadow.MaxLength = 4;
            this.txbShadow.Name = "txbShadow";
            this.txbShadow.Size = new System.Drawing.Size(43, 20);
            this.txbShadow.TabIndex = 16;
            this.txbShadow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbShadow.TextChanged += new System.EventHandler(this.txbShadow_TextChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::AppEditImage.Properties.Resources.icons8_contrast_24;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(9, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 15;
            this.label2.Text = "          Shadow";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarShadow
            // 
            this.trackBarShadow.AutoSize = false;
            this.trackBarShadow.Location = new System.Drawing.Point(5, 326);
            this.trackBarShadow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.trackBarShadow.Maximum = 100;
            this.trackBarShadow.Minimum = -100;
            this.trackBarShadow.Name = "trackBarShadow";
            this.trackBarShadow.Size = new System.Drawing.Size(267, 25);
            this.trackBarShadow.TabIndex = 14;
            this.trackBarShadow.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarShadow.ValueChanged += new System.EventHandler(this.trackBarShadow_ValueChanged);
            this.trackBarShadow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarShadow_MouseUp);
            // 
            // txbHighlight
            // 
            this.txbHighlight.BackColor = System.Drawing.Color.Black;
            this.txbHighlight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txbHighlight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.txbHighlight.ForeColor = System.Drawing.Color.White;
            this.txbHighlight.Location = new System.Drawing.Point(229, 217);
            this.txbHighlight.Margin = new System.Windows.Forms.Padding(4);
            this.txbHighlight.MaxLength = 4;
            this.txbHighlight.Name = "txbHighlight";
            this.txbHighlight.Size = new System.Drawing.Size(43, 20);
            this.txbHighlight.TabIndex = 13;
            this.txbHighlight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbHighlight.TextChanged += new System.EventHandler(this.txbHighlight_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::AppEditImage.Properties.Resources.icons8_contrast_24;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "          Highlight";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarHighlight
            // 
            this.trackBarHighlight.AutoSize = false;
            this.trackBarHighlight.Location = new System.Drawing.Point(5, 252);
            this.trackBarHighlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.trackBarHighlight.Maximum = 100;
            this.trackBarHighlight.Minimum = -100;
            this.trackBarHighlight.Name = "trackBarHighlight";
            this.trackBarHighlight.Size = new System.Drawing.Size(267, 25);
            this.trackBarHighlight.TabIndex = 11;
            this.trackBarHighlight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarHighlight.ValueChanged += new System.EventHandler(this.trackBarHighlight_ValueChanged);
            this.trackBarHighlight.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarHighlight_MouseUp);
            // 
            // LightColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LightColor";
            this.Size = new System.Drawing.Size(307, 838);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarShadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHighlight)).EndInit();
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
        public System.Windows.Forms.TextBox txbHighlight;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TrackBar trackBarHighlight;
        public System.Windows.Forms.TextBox txbShadow;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TrackBar trackBarShadow;
    }
}
