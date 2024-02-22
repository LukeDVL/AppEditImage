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

namespace AppEditImage.Controllers
{
    public partial class Filter : UserControl
    {
        private frmMain main;
        public Filter(frmMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void btnGaussianBlur_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage); ;
                Filters.GaussianBlur(img,4);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
            }
        }


        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);
                Filters.Grayscale(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);
                Filters.Invert(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnMeanRemoval_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);
                Filters.MeanRemoval(img,9);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);
                Filters.Sepia(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnCool_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);

                Filters.Cool(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnWarm_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);

                Filters.Warm(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(ImageHistoryManager.Instance.currentImage);

                Filters.Emboss(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImageOther(img);
                main.isEdited = true;
            }
        }
    }
}
