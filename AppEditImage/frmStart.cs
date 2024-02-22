using AppEditImage.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEditImage
{
    public partial class frmStart : Form
    {
        private frmMain main;
        public frmStart()
        {
            InitializeComponent();
            
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif;*.tiff|All files (*.*)|*.*";
                openFileDialog.Title = "Select an Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImageHistoryManager.Instance.originalImage = new Bitmap(openFileDialog.FileName);
                    ImageHistoryManager.Instance.currentImage = new Bitmap(openFileDialog.FileName);
                    ImageHistoryManager.Instance.SaveHistoryState(ImageHistoryManager.Instance.currentImage);

                    main = new frmMain();
                    // Đăng ký sự kiện đóng form chính
                    main.FormClosedEvent += frmMain_FormClosed;
                    
                    // Hiển thị FormMain
                    main.Show();
                    main.ShowImage();
                    // Đóng FormStart
                    this.Hide();
                }
            }
        }
        private void frmMain_FormClosed(object sender, EventArgs e)
        {
            // Hiển thị lại FormStart khi FormMain đóng
            this.Show();
        }
    }
}
