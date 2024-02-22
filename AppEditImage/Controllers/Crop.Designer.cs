
namespace AppEditImage.Controllers
{
    partial class Crop
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
            this.btnFlipVertical = new System.Windows.Forms.Button();
            this.btnFlipHorizontal = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.lbRotate = new System.Windows.Forms.Label();
            this.btnCrop = new System.Windows.Forms.Button();
            this.lbCrop = new System.Windows.Forms.Label();
            this.pnlTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTools
            // 
            this.pnlTools.AutoScroll = true;
            this.pnlTools.BackColor = System.Drawing.Color.Black;
            this.pnlTools.Controls.Add(this.btnCrop);
            this.pnlTools.Controls.Add(this.lbCrop);
            this.pnlTools.Controls.Add(this.btnFlipVertical);
            this.pnlTools.Controls.Add(this.btnFlipHorizontal);
            this.pnlTools.Controls.Add(this.btnRotateRight);
            this.pnlTools.Controls.Add(this.btnRotateLeft);
            this.pnlTools.Controls.Add(this.lbRotate);
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(307, 841);
            this.pnlTools.TabIndex = 0;
            // 
            // btnFlipVertical
            // 
            this.btnFlipVertical.FlatAppearance.BorderSize = 0;
            this.btnFlipVertical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipVertical.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFlipVertical.ForeColor = System.Drawing.Color.White;
            this.btnFlipVertical.Image = global::AppEditImage.Properties.Resources.icons8_flip_vertical_32;
            this.btnFlipVertical.Location = new System.Drawing.Point(155, 192);
            this.btnFlipVertical.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlipVertical.Name = "btnFlipVertical";
            this.btnFlipVertical.Size = new System.Drawing.Size(140, 92);
            this.btnFlipVertical.TabIndex = 5;
            this.btnFlipVertical.Text = "Flip Vertical";
            this.btnFlipVertical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFlipVertical.UseVisualStyleBackColor = true;
            this.btnFlipVertical.Click += new System.EventHandler(this.btnFlipVertical_Click);
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.FlatAppearance.BorderSize = 0;
            this.btnFlipHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipHorizontal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnFlipHorizontal.ForeColor = System.Drawing.Color.White;
            this.btnFlipHorizontal.Image = global::AppEditImage.Properties.Resources.icons8_flip_horizontal_32;
            this.btnFlipHorizontal.Location = new System.Drawing.Point(11, 192);
            this.btnFlipHorizontal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(140, 92);
            this.btnFlipHorizontal.TabIndex = 4;
            this.btnFlipHorizontal.Text = "Flip Horizontal";
            this.btnFlipHorizontal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFlipHorizontal.UseVisualStyleBackColor = true;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.FlatAppearance.BorderSize = 0;
            this.btnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateRight.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRotateRight.ForeColor = System.Drawing.Color.White;
            this.btnRotateRight.Image = global::AppEditImage.Properties.Resources.icons8_rotate_right_32;
            this.btnRotateRight.Location = new System.Drawing.Point(155, 92);
            this.btnRotateRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(140, 92);
            this.btnRotateRight.TabIndex = 3;
            this.btnRotateRight.Text = "Rotate Right";
            this.btnRotateRight.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRotateRight.UseVisualStyleBackColor = true;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.FlatAppearance.BorderSize = 0;
            this.btnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotateLeft.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRotateLeft.ForeColor = System.Drawing.Color.White;
            this.btnRotateLeft.Image = global::AppEditImage.Properties.Resources.icons8_rotate_left_32;
            this.btnRotateLeft.Location = new System.Drawing.Point(11, 92);
            this.btnRotateLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(140, 92);
            this.btnRotateLeft.TabIndex = 1;
            this.btnRotateLeft.Text = "Rotate Left";
            this.btnRotateLeft.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRotateLeft.UseVisualStyleBackColor = true;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // lbRotate
            // 
            this.lbRotate.AutoSize = true;
            this.lbRotate.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRotate.ForeColor = System.Drawing.Color.White;
            this.lbRotate.Location = new System.Drawing.Point(38, 25);
            this.lbRotate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRotate.Name = "lbRotate";
            this.lbRotate.Size = new System.Drawing.Size(81, 27);
            this.lbRotate.TabIndex = 0;
            this.lbRotate.Text = "ROTATE";
            // 
            // btnCrop
            // 
            this.btnCrop.FlatAppearance.BorderSize = 0;
            this.btnCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrop.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCrop.ForeColor = System.Drawing.Color.White;
            this.btnCrop.Image = global::AppEditImage.Properties.Resources.icons8_crop_35;
            this.btnCrop.Location = new System.Drawing.Point(11, 396);
            this.btnCrop.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(140, 92);
            this.btnCrop.TabIndex = 7;
            this.btnCrop.Text = "Crop";
            this.btnCrop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // lbCrop
            // 
            this.lbCrop.AutoSize = true;
            this.lbCrop.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCrop.ForeColor = System.Drawing.Color.White;
            this.lbCrop.Location = new System.Drawing.Point(38, 329);
            this.lbCrop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCrop.Name = "lbCrop";
            this.lbCrop.Size = new System.Drawing.Size(63, 27);
            this.lbCrop.TabIndex = 6;
            this.lbCrop.Text = "CROP";
            // 
            // Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlTools);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Crop";
            this.Size = new System.Drawing.Size(307, 841);
            this.pnlTools.ResumeLayout(false);
            this.pnlTools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTools;
        private System.Windows.Forms.Label lbRotate;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnFlipHorizontal;
        private System.Windows.Forms.Button btnFlipVertical;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.Label lbCrop;
    }
}
