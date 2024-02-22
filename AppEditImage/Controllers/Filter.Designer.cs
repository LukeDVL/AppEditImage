
namespace AppEditImage.Controllers
{
    partial class Filter
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
            this.pnlTools = new System.Windows.Forms.Panel();
            this.btnMeanRemoval = new System.Windows.Forms.Button();
            this.lbFilter = new System.Windows.Forms.Label();
            this.btnCool = new System.Windows.Forms.Button();
            this.btnWarm = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnEmboss = new System.Windows.Forms.Button();
            this.btnGaussianBlur = new System.Windows.Forms.Button();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.AutoScroll = true;
            this.pnlTools.BackColor = System.Drawing.Color.Black;
            this.pnlTools.Controls.Add(this.btnCool);
            this.pnlTools.Controls.Add(this.btnWarm);
            this.pnlTools.Controls.Add(this.btnSepia);
            this.pnlTools.Controls.Add(this.btnMeanRemoval);
            this.pnlTools.Controls.Add(this.btnInvert);
            this.pnlTools.Controls.Add(this.btnGrayscale);
            this.pnlTools.Controls.Add(this.btnEmboss);
            this.pnlTools.Controls.Add(this.btnGaussianBlur);
            this.pnlTools.Controls.Add(this.lbFilter);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(307, 838);
            this.pnlTools.TabIndex = 1;
            // 
            // btnMeanRemoval
            // 
            this.btnMeanRemoval.BackgroundImage = global::AppEditImage.Properties.Resources.mean_removal;
            this.btnMeanRemoval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMeanRemoval.FlatAppearance.BorderSize = 0;
            this.btnMeanRemoval.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeanRemoval.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMeanRemoval.ForeColor = System.Drawing.Color.White;
            this.btnMeanRemoval.Location = new System.Drawing.Point(155, 392);
            this.btnMeanRemoval.Margin = new System.Windows.Forms.Padding(4);
            this.btnMeanRemoval.Name = "btnMeanRemoval";
            this.btnMeanRemoval.Size = new System.Drawing.Size(140, 92);
            this.btnMeanRemoval.TabIndex = 6;
            this.btnMeanRemoval.Text = "Mean Removal";
            this.btnMeanRemoval.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeanRemoval.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMeanRemoval.UseVisualStyleBackColor = true;
            this.btnMeanRemoval.Click += new System.EventHandler(this.btnMeanRemoval_Click);
            // 
            // lbFilter
            // 
            this.lbFilter.AutoSize = true;
            this.lbFilter.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbFilter.ForeColor = System.Drawing.Color.White;
            this.lbFilter.Location = new System.Drawing.Point(38, 25);
            this.lbFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(69, 27);
            this.lbFilter.TabIndex = 0;
            this.lbFilter.Text = "FILTER";
            // 
            // btnCool
            // 
            this.btnCool.BackgroundImage = global::AppEditImage.Properties.Resources.cool;
            this.btnCool.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCool.FlatAppearance.BorderSize = 0;
            this.btnCool.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCool.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCool.ForeColor = System.Drawing.Color.White;
            this.btnCool.Location = new System.Drawing.Point(11, 192);
            this.btnCool.Margin = new System.Windows.Forms.Padding(4);
            this.btnCool.Name = "btnCool";
            this.btnCool.Size = new System.Drawing.Size(140, 92);
            this.btnCool.TabIndex = 12;
            this.btnCool.Text = "Cool";
            this.btnCool.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCool.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCool.UseVisualStyleBackColor = true;
            this.btnCool.Click += new System.EventHandler(this.btnCool_Click);
            // 
            // btnWarm
            // 
            this.btnWarm.BackgroundImage = global::AppEditImage.Properties.Resources.warm;
            this.btnWarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWarm.FlatAppearance.BorderSize = 0;
            this.btnWarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWarm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnWarm.ForeColor = System.Drawing.Color.White;
            this.btnWarm.Location = new System.Drawing.Point(155, 192);
            this.btnWarm.Margin = new System.Windows.Forms.Padding(4);
            this.btnWarm.Name = "btnWarm";
            this.btnWarm.Size = new System.Drawing.Size(140, 92);
            this.btnWarm.TabIndex = 11;
            this.btnWarm.Text = "Warm";
            this.btnWarm.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnWarm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnWarm.UseVisualStyleBackColor = true;
            this.btnWarm.Click += new System.EventHandler(this.btnWarm_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.BackgroundImage = global::AppEditImage.Properties.Resources.sepia;
            this.btnSepia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSepia.FlatAppearance.BorderSize = 0;
            this.btnSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSepia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSepia.ForeColor = System.Drawing.Color.White;
            this.btnSepia.Location = new System.Drawing.Point(155, 92);
            this.btnSepia.Margin = new System.Windows.Forms.Padding(4);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(140, 92);
            this.btnSepia.TabIndex = 7;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSepia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.BackgroundImage = global::AppEditImage.Properties.Resources.invert;
            this.btnInvert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvert.FlatAppearance.BorderSize = 0;
            this.btnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvert.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnInvert.ForeColor = System.Drawing.Color.White;
            this.btnInvert.Location = new System.Drawing.Point(11, 292);
            this.btnInvert.Margin = new System.Windows.Forms.Padding(4);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(140, 92);
            this.btnInvert.TabIndex = 5;
            this.btnInvert.Text = "Invert";
            this.btnInvert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.BackgroundImage = global::AppEditImage.Properties.Resources.grayscale;
            this.btnGrayscale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrayscale.FlatAppearance.BorderSize = 0;
            this.btnGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrayscale.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGrayscale.ForeColor = System.Drawing.Color.White;
            this.btnGrayscale.Location = new System.Drawing.Point(11, 92);
            this.btnGrayscale.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(140, 92);
            this.btnGrayscale.TabIndex = 4;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGrayscale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnEmboss
            // 
            this.btnEmboss.BackgroundImage = global::AppEditImage.Properties.Resources.emboss;
            this.btnEmboss.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmboss.FlatAppearance.BorderSize = 0;
            this.btnEmboss.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmboss.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEmboss.ForeColor = System.Drawing.Color.White;
            this.btnEmboss.Location = new System.Drawing.Point(155, 292);
            this.btnEmboss.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmboss.Name = "btnEmboss";
            this.btnEmboss.Size = new System.Drawing.Size(140, 92);
            this.btnEmboss.TabIndex = 3;
            this.btnEmboss.Text = "Emboss";
            this.btnEmboss.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEmboss.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEmboss.UseVisualStyleBackColor = true;
            this.btnEmboss.Click += new System.EventHandler(this.btnEmboss_Click);
            // 
            // btnGaussianBlur
            // 
            this.btnGaussianBlur.BackgroundImage = global::AppEditImage.Properties.Resources.gaussian_blur;
            this.btnGaussianBlur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGaussianBlur.FlatAppearance.BorderSize = 0;
            this.btnGaussianBlur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGaussianBlur.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGaussianBlur.ForeColor = System.Drawing.Color.White;
            this.btnGaussianBlur.Location = new System.Drawing.Point(11, 392);
            this.btnGaussianBlur.Margin = new System.Windows.Forms.Padding(4);
            this.btnGaussianBlur.Name = "btnGaussianBlur";
            this.btnGaussianBlur.Size = new System.Drawing.Size(140, 92);
            this.btnGaussianBlur.TabIndex = 1;
            this.btnGaussianBlur.Text = "Gaussian Blur";
            this.btnGaussianBlur.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGaussianBlur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGaussianBlur.UseVisualStyleBackColor = true;
            this.btnGaussianBlur.Click += new System.EventHandler(this.btnGaussianBlur_Click);
            // 
            // Filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.pnlTools);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Filter";
            this.Size = new System.Drawing.Size(307, 838);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnEmboss;
        private System.Windows.Forms.Button btnGaussianBlur;
        private System.Windows.Forms.Label lbFilter;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Button btnMeanRemoval;
        private System.Windows.Forms.Button btnWarm;
        private System.Windows.Forms.Button btnCool;
    }
}
