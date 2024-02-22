
namespace AppEditImage
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.fpnlHeader = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCompare = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.pnlTools = new System.Windows.Forms.Panel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnLightColor = new System.Windows.Forms.Button();
            this.btnCrop = new System.Windows.Forms.Button();
            this.btnFilter = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.fpnlHeader.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Black;
            this.pnlHeader.Controls.Add(this.panel1);
            this.pnlHeader.Controls.Add(this.fpnlHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1800, 57);
            this.pnlHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(92, 57);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::AppEditImage.Properties.Resources.icons8_back_24;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnBack.Size = new System.Drawing.Size(73, 57);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // fpnlHeader
            // 
            this.fpnlHeader.Controls.Add(this.btnSave);
            this.fpnlHeader.Controls.Add(this.btnCompare);
            this.fpnlHeader.Controls.Add(this.btnRedo);
            this.fpnlHeader.Controls.Add(this.btnUndo);
            this.fpnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlHeader.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.fpnlHeader.Location = new System.Drawing.Point(0, 0);
            this.fpnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.fpnlHeader.Name = "fpnlHeader";
            this.fpnlHeader.Size = new System.Drawing.Size(1800, 57);
            this.fpnlHeader.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = global::AppEditImage.Properties.Resources.icons8_save_24;
            this.btnSave.Location = new System.Drawing.Point(1723, 4);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSave.Size = new System.Drawing.Size(73, 49);
            this.btnSave.TabIndex = 2;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCompare
            // 
            this.btnCompare.FlatAppearance.BorderSize = 0;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCompare.ForeColor = System.Drawing.Color.White;
            this.btnCompare.Image = global::AppEditImage.Properties.Resources.icons8_bring_forward_24;
            this.btnCompare.Location = new System.Drawing.Point(1642, 4);
            this.btnCompare.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCompare.Size = new System.Drawing.Size(73, 49);
            this.btnCompare.TabIndex = 3;
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnCompare_MouseDown);
            this.btnCompare.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnCompare_MouseUp);
            // 
            // btnRedo
            // 
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.Image = global::AppEditImage.Properties.Resources.icons8_redo_32;
            this.btnRedo.Location = new System.Drawing.Point(1561, 4);
            this.btnRedo.Margin = new System.Windows.Forms.Padding(4);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnRedo.Size = new System.Drawing.Size(73, 49);
            this.btnRedo.TabIndex = 4;
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.Image = global::AppEditImage.Properties.Resources.icons8_undo_32;
            this.btnUndo.Location = new System.Drawing.Point(1480, 4);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUndo.Size = new System.Drawing.Size(73, 49);
            this.btnUndo.TabIndex = 5;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMain.Controls.Add(this.picImg);
            this.pnlMain.Controls.Add(this.pnlTools);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(99, 57);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1701, 840);
            this.pnlMain.TabIndex = 0;
            // 
            // picImg
            // 
            this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImg.Location = new System.Drawing.Point(307, 0);
            this.picImg.Margin = new System.Windows.Forms.Padding(4);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(1392, 838);
            this.picImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImg.TabIndex = 1;
            this.picImg.TabStop = false;
            this.picImg.Paint += new System.Windows.Forms.PaintEventHandler(this.picImg_Paint);
            this.picImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseDown);
            this.picImg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseMove);
            this.picImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseUp);
            // 
            // pnlTools
            // 
            this.pnlTools.BackColor = System.Drawing.Color.Black;
            this.pnlTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTools.Location = new System.Drawing.Point(0, 0);
            this.pnlTools.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTools.Name = "pnlTools";
            this.pnlTools.Size = new System.Drawing.Size(307, 838);
            this.pnlTools.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.pnlSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSidebar.Controls.Add(this.btnLightColor);
            this.pnlSidebar.Controls.Add(this.btnCrop);
            this.pnlSidebar.Controls.Add(this.btnFilter);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 57);
            this.pnlSidebar.Margin = new System.Windows.Forms.Padding(4);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(99, 840);
            this.pnlSidebar.TabIndex = 0;
            // 
            // btnLightColor
            // 
            this.btnLightColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLightColor.FlatAppearance.BorderSize = 0;
            this.btnLightColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightColor.Image = global::AppEditImage.Properties.Resources.icons8_slider_32;
            this.btnLightColor.Location = new System.Drawing.Point(0, 156);
            this.btnLightColor.Margin = new System.Windows.Forms.Padding(4);
            this.btnLightColor.Name = "btnLightColor";
            this.btnLightColor.Size = new System.Drawing.Size(97, 78);
            this.btnLightColor.TabIndex = 2;
            this.btnLightColor.UseVisualStyleBackColor = true;
            this.btnLightColor.Click += new System.EventHandler(this.btnLightColor_Click);
            // 
            // btnCrop
            // 
            this.btnCrop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrop.FlatAppearance.BorderSize = 0;
            this.btnCrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrop.Image = global::AppEditImage.Properties.Resources.icons8_crop_35;
            this.btnCrop.Location = new System.Drawing.Point(0, 78);
            this.btnCrop.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(97, 78);
            this.btnCrop.TabIndex = 1;
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // btnFilter
            // 
            this.btnFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Image = global::AppEditImage.Properties.Resources.icons8_color_filter_32;
            this.btnFilter.Location = new System.Drawing.Point(0, 0);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(97, 78);
            this.btnFilter.TabIndex = 0;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImageEdit";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.fpnlHeader.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FlowLayoutPanel fpnlHeader;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Panel pnlTools;
        public System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLightColor;
        private System.Windows.Forms.Button btnFilter;
    }
}

