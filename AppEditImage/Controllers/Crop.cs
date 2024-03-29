﻿using AppEditImage.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEditImage.Controllers
{
    public partial class Crop : UserControl
    {
        private frmMain main;
        public bool CropActivated = false;
        public Crop(frmMain main)
        {
            InitializeComponent();

            this.main = main;
        }
     
        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap rotatedImage = new Bitmap(ImageHistoryManager.Instance.currentImage);

                //xoay sang trái
                rotatedImage.RotateFlip(RotateFlipType.Rotate270FlipNone);

                // Lưu trạng thái trước khi thay đổi
                ImageHistoryManager.Instance.SaveHistoryState(rotatedImage);
                ImageHistoryManager.Instance.currentImage = rotatedImage;
                main.ShowImage(rotatedImage);
                main.isEdited = true;
            }
        }

        private void btnRotateRight_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                
                Bitmap rotatedImage = new Bitmap(ImageHistoryManager.Instance.currentImage);

                //xoay sang phải
                rotatedImage.RotateFlip(RotateFlipType.Rotate90FlipNone);

                // Lưu trạng thái trước khi thay đổi
                ImageHistoryManager.Instance.SaveHistoryState(rotatedImage);
                ImageHistoryManager.Instance.currentImage = rotatedImage;
                main.ShowImage(rotatedImage);
                main.isEdited = true;
            }
        }

        private void btnFlipVertical_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
               
                Bitmap flipImage = new Bitmap(ImageHistoryManager.Instance.currentImage);

                // Thực hiện lật ảnh theo chiều dọc
                flipImage.RotateFlip(RotateFlipType.RotateNoneFlipY);

                // Lưu trạng thái trước khi thay đổi
                ImageHistoryManager.Instance.SaveHistoryState(flipImage);
                ImageHistoryManager.Instance.currentImage = flipImage;
                main.ShowImage(flipImage);
                main.isEdited = true;
            }
        }

        private void btnFlipHorizontal_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {

                Bitmap flipImage = new Bitmap(ImageHistoryManager.Instance.currentImage);

                // Thực hiện lật ảnh theo chiều ngang
                flipImage.RotateFlip(RotateFlipType.RotateNoneFlipX);

                // Lưu trạng thái trước khi thay đổi
                ImageHistoryManager.Instance.SaveHistoryState(flipImage);
                ImageHistoryManager.Instance.currentImage = flipImage;
                main.ShowImage(flipImage);
                main.isEdited = true;
            }

        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            if (CropActivated)
            {
                // Nếu nút đã được kích hoạt, vô hiệu hóa nút và ngưng chức năng cắt ảnh
                CropActivated = false;
                btnCrop.BackColor = Color.Black; // Màu mặc định
            }
            else
            {
                // Nếu nút chưa được kích hoạt, kích hoạt nút và cho phép chức năng cắt ảnh
                CropActivated = true;
                btnCrop.BackColor = Color.Silver; // Màu của nút khi được kích hoạt
            }
        }
    }
}
