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
        private Bitmap originImage;
        public Filter(frmMain main)
        {
            InitializeComponent();

            this.main = main;
        }

        private void btnGaussianBlur_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg()); ;
                Filters.GaussianBlur(img,4);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
            }
        }


        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());
                Filters.Grayscale(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());
                Filters.Invert(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnMeanRemoval_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());
                Filters.MeanRemoval(img,9);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());
                Filters.Sepia(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnCool_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());

                Filters.Cool(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnWarm_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());

                Filters.Warm(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private void btnEmboss_Click(object sender, EventArgs e)
        {
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                Bitmap img = new Bitmap(getOgiginImg());

                Filters.Emboss(img);
                ImageHistoryManager.Instance.SaveHistoryState(img);
                main.ShowImage(img);
                main.isEdited = true;
            }
        }

        private Bitmap getOgiginImg()
        {
            if(originImage == null)
            {
                originImage = ImageHistoryManager.Instance.currentNode.Value.Img;
            }
            return originImage;
        }

        private void pnlTools_Paint(object sender, PaintEventArgs e)
        {
            originImage = ImageHistoryManager.Instance.currentNode.Value.Img;
        }
    }
}
