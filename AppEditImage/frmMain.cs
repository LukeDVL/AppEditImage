using AppEditImage.Controllers;
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
    public partial class frmMain : Form
    {
        public event EventHandler FormClosedEvent;
        private Crop cropController;
        private LightColor lightColorContronller;
        private Filter filterContronller;
        private Bitmap imgNow;
        private bool mouseDown = false;
        private Point a;
        private Point b;
        private Rectangle Rect;
        public bool isEdited = false;
        public frmMain()
        {
            InitializeComponent();
            
            cropController = new Crop(this);
            lightColorContronller = new LightColor(this);
            filterContronller = new Filter(this);
            start();
        }

        public void ShowImage()
        {
            picImg.Image = ImageHistoryManager.Instance.currentImage;

        }
        public void ShowImageOther(Bitmap image)
        {
            picImg.Image = image;

        }

        public void start()
        {
            pnlTools.Controls.Clear();

            pnlTools.Controls.Add(filterContronller);

            SetButtonBackground(btnFilter);

        }

        private void Undo()
        {
            if (ImageHistoryManager.Instance.currentNode != null && ImageHistoryManager.Instance.currentNode.Previous != null)
            {
                ImageHistoryManager.Instance.currentNode = ImageHistoryManager.Instance.currentNode.Previous;
                ImageHistoryManager.Instance.currentImage = new Bitmap(ImageHistoryManager.Instance.currentNode.Value);
                lightColorContronller.trackBarBrightness.Value = 0;
                lightColorContronller.txbBrightness.Text = "0";

                lightColorContronller.trackBarContrast.Value = 0;
                lightColorContronller.txbContrast.Text = "0";
                ShowImage();
            }
        }

        private void Redo()
        {
            if (ImageHistoryManager.Instance.currentNode != null && ImageHistoryManager.Instance.currentNode.Next != null)
            {
                ImageHistoryManager.Instance.currentNode = ImageHistoryManager.Instance.currentNode.Next;
                ImageHistoryManager.Instance.currentImage = new Bitmap(ImageHistoryManager.Instance.currentNode.Value);

                ShowImage();
            }
        }

        public void Save()
        {
            saveFileDialog.Title = "Save file...";
            saveFileDialog.InitialDirectory = "D:\\";
            saveFileDialog.DefaultExt = "jpg";
            saveFileDialog.Filter = "image file (*.BMP, *.JPG, *.JPEG|*.bmg;*.jpg;*.jpeg)";
            saveFileDialog.OverwritePrompt = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                picImg.Image.Save(saveFileDialog.FileName);
                isEdited = false;
            }
        }

        public void btnUndo_Click(object sender, EventArgs e)
        {
            Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            Redo();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
            if (isEdited)
            {
                // Hiển thị cảnh báo khi có thay đổi chưa được lưu
                DialogResult result = MessageBox.Show("Do you want to save changes before quitting?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Nếu người dùng chọn "Yes", thực hiện lưu và sau đó thoát
                    Save();
                    ImageHistoryManager.Instance.ClearHistory();
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    this.Hide();
                }
                else if (result == DialogResult.No)
                {
                    // Nếu người dùng chọn "No", thoát mà không lưu
                    ImageHistoryManager.Instance.ClearHistory();
                    FormClosedEvent?.Invoke(this, EventArgs.Empty);
                    this.Hide();
                }
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (isEdited)
                {
                    // Hiển thị cảnh báo khi có thay đổi chưa được lưu
                    DialogResult result = MessageBox.Show("Do you want to save changes before quitting?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        // Nếu người dùng chọn "Yes", thực hiện lưu và sau đó thoát
                        Save();
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        // Nếu người dùng chọn "No", thoát mà không lưu
                        Application.Exit();
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        // Nếu người dùng chọn "Cancel", hủy đóng form
                        e.Cancel = true;
                    }
                }
                else
                {
                    Application.Exit();
                }
                
            }
        }
        private void SetButtonBackground(Button clickedButton)
        {
            // Đặt màu nền của tất cả các nút trong pnlSidebar
            foreach (Control control in pnlSidebar.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.BackColor = Color.FromArgb(38, 38, 38);
                }
            }

            // Đặt màu nền của nút được nhấn
            clickedButton.BackColor = Color.Black;
        }
        private void btnCrop_Click(object sender, EventArgs e)
        {
            if (!pnlTools.Controls.Contains(cropController))
            {
                pnlTools.Controls.Clear();

                pnlTools.Controls.Add(cropController);

                SetButtonBackground(btnCrop);
            }
        }

        private void btnLightColor_Click(object sender, EventArgs e)
        {
            if (!pnlTools.Controls.Contains(lightColorContronller))
            {
                pnlTools.Controls.Clear();

                pnlTools.Controls.Add(lightColorContronller);

                SetButtonBackground(btnLightColor);
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (!pnlTools.Controls.Contains(filterContronller))
            {
                pnlTools.Controls.Clear();

                pnlTools.Controls.Add(filterContronller);

                SetButtonBackground(btnFilter);
            }
        }

        private void btnCompare_MouseUp(object sender, MouseEventArgs e)
        {
            // Khi nút được thả ra, chuyển về ảnh đang sửa
            picImg.Image = imgNow;
            imgNow = null;


        }

        private void btnCompare_MouseDown(object sender, MouseEventArgs e)
        {
            // Khi nút được ấn giữ, chuyển đổi giữa ảnh gốc và ảnh đang sửa
            imgNow = (Bitmap)picImg.Image;
            picImg.Image = ImageHistoryManager.Instance.originalImage;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();

        }

        private void picImg_MouseDown(object sender, MouseEventArgs e)
        {
            
            if (cropController.CropActivated)
            {
                if (e.Button == MouseButtons.Left)
                {
                    mouseDown = true;
                    a = e.Location;
                }

            }
            
        }

        private void picImg_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                b = e.Location;
                picImg.Invalidate(); // Vô hiệu hóa điều khiển để kích hoạt sự kiện Paint
            }
        }
        //! this is not good
        private void picImg_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                b = e.Location;
                mouseDown = false;

                if (Rect != null)
                {
                    double ratioWi = (double)picImg.Image.Width / picImg.Image.Height;
                    double ratioHi = (double)picImg.Image.Height / picImg.Image.Width;

                    int offsetX = (int)((picImg.Width - (picImg.Height * ratioWi)) / 2);
                 
                    
                    int offsetY = (int)((picImg.Height - (picImg.Width * ratioHi)) / 2);
                    offsetX = offsetX < 0 ? 0 : offsetX;
                    offsetY = offsetY < 0 ? 0 : offsetY;

                    Bitmap bitm = new Bitmap(picImg.Image, picImg.Width - (offsetX *2), picImg.Height - (offsetY * 2));
                    Bitmap crop = new Bitmap(Rect.Width, Rect.Height);                   

                    Rectangle newRect = new Rectangle();
                    newRect.X = Rect.X < offsetX ? 0 : Rect.X - offsetX;
                    newRect.Y = Rect.Y < offsetY ? 0 : Rect.Y - offsetY;

                    newRect.Width = Rect.Width - (Rect.X > offsetX ? 0 : Rect.X - offsetX);

                    newRect.Height = Rect.Height - (Rect.Y > offsetY ? 0 : Rect.Y - offsetY);

                    using (Graphics g = Graphics.FromImage(crop))
                    {
                        g.DrawImage(bitm, 0, 0, newRect, GraphicsUnit.Pixel);
                    }


                    picImg.Image = crop;
                    ImageHistoryManager.Instance.SaveHistoryState(crop);
                    ImageHistoryManager.Instance.currentImage = crop;
                    isEdited = true;


                }
            }
        }

        private Rectangle GetRect()
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(a.X, b.X);
            Rect.Y = Math.Min(a.Y, b.Y);
            Rect.Width = Math.Abs(a.X - b.X);
            Rect.Height = Math.Abs(a.Y - b.Y);
            return Rect;
        }

        private void picImg_Paint(object sender, PaintEventArgs e)
        {
            if (mouseDown)
            {
                e.Graphics.DrawRectangle(Pens.Black, GetRect());
            }
        }
    }
}
