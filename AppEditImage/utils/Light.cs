using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEditImage.utils
{
    static class Light
    {
        public static void Brightness(Bitmap bmp, int brightnessValue)
        {
            if (brightnessValue == 0) return;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                unsafe
                {
                    byte* ptr = (byte*)bmpData.Scan0.ToPointer();
                    int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                    while ((int)ptr < stopAddress)
                    {
                        int val = ptr[2] + brightnessValue;
                        ptr[2] = (byte)Math.Max(0, Math.Min(255, val));

                        val = ptr[1] + brightnessValue;
                        ptr[1] = (byte)Math.Max(0, Math.Min(255, val));

                        val = ptr[0] + brightnessValue;
                        ptr[0] = (byte)Math.Max(0, Math.Min(255, val));

                        ptr += 3;
                    }
                }
            }
            finally
            {
                // Mở khóa bits của ảnh sau khi quá trình chỉnh sửa đã hoàn thành
                bmp.UnlockBits(bmpData);
            }
        }
        public static void Contrast(Bitmap bmp, int contrastValue)
        {
            if (contrastValue == 0) return;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                unsafe
                {
                    byte* ptr = (byte*)bmpData.Scan0.ToPointer();

                    int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                    double contrast = (100.0 + contrastValue) / 100.0;

                    contrast *= contrast;

                    while ((int)ptr < stopAddress)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            double pixel = ptr[i] / 255.0;
                            pixel -= 0.5;
                            pixel *= contrast;
                            pixel += 0.5;
                            pixel *= 255;

                            ptr[i] = (byte)Math.Max(0, Math.Min(255, pixel));

                        }

                        ptr += 3;
                    }
                }
            }
            finally
            {
                // Mở khóa bits của ảnh sau khi quá trình chỉnh sửa đã hoàn thành
                bmp.UnlockBits(bmpData);
            }
        }

        public static void Highlight(Bitmap bmp, int highlightValue)
        {
            if (highlightValue == 0) return;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                unsafe
                {
                    byte* ptr = (byte*)bmpData.Scan0.ToPointer();

                    int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                    double highlight = (500.0 + highlightValue) / 500.0;

                    while ((int)ptr < stopAddress)
                    {
                        if((ptr[0] + ptr[1]  + ptr[2]) /3 > 120)
                        {
                            double pixel = ptr[2] / 255.0;
                            pixel -= 0.5;
                            pixel *= highlight;
                            pixel += 0.5;
                            int val = (int)(pixel * 255);

                            ptr[2] = (byte)Math.Max(0, Math.Min(255, val));

                            pixel = ptr[1] / 255.0;
                            pixel -= 0.5;
                            pixel *= highlight;
                            pixel += 0.5;
                            val = (int)(pixel * 255);
                            ptr[1] = (byte)Math.Max(0, Math.Min(255, val));

                            pixel = ptr[0] / 255.0;
                            pixel -= 0.5;
                            pixel *= highlight;
                            pixel += 0.5;
                            val = (int)(pixel * 255);
                            ptr[0] = (byte)Math.Max(0, Math.Min(255, val));
                        }                 

                        ptr += 3;
                    }
                }
            }
            finally
            {
                // Mở khóa bits của ảnh sau khi quá trình chỉnh sửa đã hoàn thành
                bmp.UnlockBits(bmpData);
            }
        }

        public static void Shadow(Bitmap bmp, int shadowValue)
        {
            if (shadowValue == 0) return;
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            try
            {
                unsafe
                {
                    byte* ptr = (byte*)bmpData.Scan0.ToPointer();

                    int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

                    double shadow = (500.0 + shadowValue) / 500.0;

                    while ((int)ptr < stopAddress)
                    {
                        if ((ptr[0] + ptr[1] + ptr[2] ) / 3 < 120)
                        {
                            double pixel = ptr[2] / 255.0;
                        
                            pixel = ((0.7 - pixel) * shadow) - (0.7 - pixel) + pixel;
                            
                            int val = (int)(pixel * 255);
                            ptr[2] = (byte)Math.Max(0, Math.Min(255, val));

                            pixel = ptr[1] / 255.0;
                            pixel = ((0.7 - pixel) * shadow) - (0.7 - pixel) + pixel;
                            val = (int)(pixel * 255);
                            ptr[1] = (byte)Math.Max(0, Math.Min(255, val));

                            pixel = ptr[0] / 255.0;                   
                            pixel = ((0.7 - pixel) * shadow) - (0.7 - pixel) + pixel;              
                            val = (int)(pixel * 255);
                            ptr[0] = (byte)Math.Max(0, Math.Min(255, val));
                        }

                        ptr += 3;
                    }
                }
            }
            finally
            {
                // Mở khóa bits của ảnh sau khi quá trình chỉnh sửa đã hoàn thành
                bmp.UnlockBits(bmpData);
            }
        }
    }
}
