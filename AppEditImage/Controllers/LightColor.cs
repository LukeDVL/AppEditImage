using AppEditImage.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEditImage.Controllers
{
    public partial class LightColor : UserControl
    {
        private frmMain main;
        Bitmap img;
        private LightState lightState;
        public LightColor(frmMain main)
        {
            InitializeComponent();

            this.main = main;

            // Đặt giá trị mặc định cho TrackBar và TextBox
            trackBarBrightness.Value = 0;
            txbBrightness.Text = "0";

            trackBarContrast.Value = 0;
            txbContrast.Text = "0";


        }

        override public void Refresh()
        {    
            base.Refresh();
        }

        private Bitmap getOriginImg()
        {

            return lightState == LightState.Empty() ? ImageHistoryManager.Instance.currentNode.Value.Img : lightState.OriginalImage;
        }

        private void UpdateValueTextBoxToTrackBar(TrackBar trackBar, TextBox textBox)
        {
            // Kiểm tra nếu TextBox không rỗng
            if (!string.IsNullOrEmpty(textBox.Text))
            {
                // Chuyển đổi giá trị từ TextBox sang kiểu số nguyên
                if (int.TryParse(textBox.Text, out int value))
                {
                    // Giới hạn giá trị từ -100 đến 100
                    value = Math.Max(-100, Math.Min(100, value));

                    // Đặt giá trị của TextBox và TrackBar
                    textBox.Text = value.ToString();
                    trackBar.Value = value;
                }
                else
                {
                    // Nếu không thể chuyển đổi thành số nguyên, đặt giá trị mặc định là 0
                    textBox.Text = "0";
                }
            }
        }

        private void trackBarBrightness_Scroll(object sender, EventArgs e)
        {

        }

        private void trackBarBrightness_ValueChanged(object sender, EventArgs e)
        {
            txbBrightness.Text = trackBarBrightness.Value.ToString();
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                img = new Bitmap(getOriginImg());

                Light.Brightness(img, trackBarBrightness.Value);
                Light.Contrast(img, trackBarContrast.Value);


                main.ShowImage(img);

            }
        }

        private void txbBrightness_TextChanged(object sender, EventArgs e)
        {
            UpdateValueTextBoxToTrackBar(trackBarBrightness, txbBrightness);

        }

        private void trackBarContrast_ValueChanged(object sender, EventArgs e)
        {
            txbContrast.Text = trackBarContrast.Value.ToString();
            if (ImageHistoryManager.Instance.currentImage != null)
            {
                img = new Bitmap(getOriginImg());

                Light.Contrast(img, trackBarContrast.Value);
                Light.Brightness(img, trackBarBrightness.Value);

                main.ShowImage(img);
            }
        }

        private void txbContrast_TextChanged(object sender, EventArgs e)
        {
            UpdateValueTextBoxToTrackBar(trackBarContrast, txbContrast);
        }

        private void handleSaveHistory()
        {
            if (lightState == LightState.Empty())
            {
                LightState newLightState = new LightState(new Bitmap(getOriginImg()))
                {
                    Brightness = trackBarBrightness.Value,
                    Contrast = trackBarContrast.Value
                };

                lightState = newLightState;
                ImageHistoryManager.Instance.SaveHistoryState(img, newLightState);
            }
            else
            {
                LightState newLightState = lightState.Clone();
                newLightState.Brightness = trackBarBrightness.Value;
                newLightState.Contrast = trackBarContrast.Value;

                lightState = newLightState;
                ImageHistoryManager.Instance.SaveHistoryState(img, newLightState);
            }
            main.isEdited = true;
        }

        private void trackBarBrightness_MouseUp(object sender, MouseEventArgs e)
        {
            handleSaveHistory();
        }

        private void trackBarContrast_MouseUp(object sender, MouseEventArgs e)
        {
            handleSaveHistory();
        }

        private void btnBrightness_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            lightState = ImageHistoryManager.Instance.currentNode.Value.lightState;

            trackBarBrightness.Value = lightState.Brightness;
            txbBrightness.Text = lightState.Brightness.ToString();

            trackBarContrast.Value = lightState.Contrast;
            txbContrast.Text = lightState.Contrast.ToString();
        }
    }
}
