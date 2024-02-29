using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEditImage.utils
{
    static class Filters
    {

		public static void GaussianBlur(Bitmap bmp, int Weight)
		{
			ConvolutionMatrix m = new ConvolutionMatrix();
			m.Apply(1);
			m.Pixel = Weight;
			m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 2;
			m.Factor = Weight + 12;

			Convolution C = new Convolution();
			C.Matrix = m;
			C.Convolution3x3(bmp);
		}

		public static void Emboss(Bitmap bmp)
		{
			ConvolutionMatrix m = new ConvolutionMatrix();
			m.Apply(-1);
			m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = 0;
			m.Pixel = 4;
			m.Offset = 127;

			Convolution C = new Convolution();
			C.Matrix = m;
			C.Convolution3x3(bmp);
		}

		public static void Grayscale(Bitmap bmp)
		{
			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), 
				ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);


			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

					while ((int)ptr < stopAddress)
					{
						*ptr = (byte)((ptr[2] * .299) + (ptr[1] * .587) + (ptr[0] * .114));
						ptr[1] = *ptr;
						ptr[2] = *ptr;

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

		public static void Invert(Bitmap bmp)
		{
			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

					while ((int)ptr < stopAddress)
					{
						ptr[0] = (byte)(255 - ptr[0]);
						ptr[1] = (byte)(255 - ptr[1]);
						ptr[2] = (byte)(255 - ptr[2]);

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

		public static void Sharpen(Bitmap bmp, int weight)
		{
			ConvolutionMatrix m = new ConvolutionMatrix();
			m.Apply(0);
			m.Pixel = weight;
			m.TopMid = m.MidLeft = m.MidRight = m.BottomMid = -2;
			m.Factor = weight - 8;

			Convolution C = new Convolution();
			C.Matrix = m;
			C.Convolution3x3(bmp);
		}

		public static void Sepia(Bitmap bmp)
		{
			int depth = 50;
			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			
			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;
					int Pixel = 0;

					while ((int)ptr < stopAddress)
					{
						ptr[0] = (byte)((.299 * ptr[2]) + (ptr[1] * .587) + (ptr[0] * .114));

						Pixel = Math.Min(255, ptr[2] + (depth * 2));
						ptr[2] = (byte)Pixel;

						Pixel = Math.Min(255, ptr[1] + depth);
						ptr[1] = (byte)Pixel;

						ptr += 3;
					}
				}
			}
			finally
			{
				bmp.UnlockBits(bmpData);
			}
		}

		public static void Cool(Bitmap bmp)
		{
			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

					while ((int)ptr < stopAddress)
					{
						Color pixelColor = Color.FromArgb(ptr[2], ptr[1], ptr[0]);
						int coolR = Math.Max(0, pixelColor.R - 50);
						int coolG = pixelColor.G;
						int coolB = Math.Min(255, pixelColor.B + 50);

						ptr[0] = (byte)coolB;
						ptr[1] = (byte)coolG;
						ptr[2] = (byte)coolR;
						ptr += 3;
					}
				}
			}
			finally
			{
				bmp.UnlockBits(bmpData);
			}
		}

		public static void Warm(Bitmap bmp)
		{
			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					int stopAddress = (int)ptr + bmpData.Stride * bmpData.Height;

					while ((int)ptr < stopAddress)
					{
						Color pixelColor = Color.FromArgb(ptr[2], ptr[1], ptr[0]);
						int warmR = Math.Min(255, pixelColor.R + 50);
						int warmG = pixelColor.G;
						int warmB = Math.Max(0, pixelColor.B - 50);

						ptr[0] = (byte)warmB;
						ptr[1] = (byte)warmG;
						ptr[2] = (byte)warmR;
						ptr += 3;
					}
				}
			}
			finally
			{
				bmp.UnlockBits(bmpData);
			}
		}
	}
}
