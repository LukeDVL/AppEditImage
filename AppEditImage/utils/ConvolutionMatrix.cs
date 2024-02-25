using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEditImage.utils
{
    class ConvolutionMatrix
    {
		public ConvolutionMatrix()
		{
			Pixel = 1;
			Factor = 1;
		}

		public void Apply(int Val)
		{
			TopLeft = TopMid = TopRight = MidLeft = MidRight = BottomLeft = BottomMid = BottomRight = Pixel = Val;
		}

		public int TopLeft { get; set; }

		public int TopMid { get; set; }

		public int TopRight { get; set; }

		public int MidLeft { get; set; }

		public int MidRight { get; set; }

		public int BottomLeft { get; set; }

		public int BottomMid { get; set; }

		public int BottomRight { get; set; }

		public int Pixel { get; set; }

		public int Factor { get; set; }

		public int Offset { get; set; }
	}


	class Convolution
	{
		public void Convolution3x3(Bitmap bmp)
		{
			int Factor = Matrix.Factor;

			if (Factor == 0) return;

			int TopLeft = Matrix.TopLeft;
			int TopMid = Matrix.TopMid;
			int TopRight = Matrix.TopRight;
			int MidLeft = Matrix.MidLeft;
			int MidRight = Matrix.MidRight;
			int BottomLeft = Matrix.BottomLeft;
			int BottomMid = Matrix.BottomMid;
			int BottomRight = Matrix.BottomRight;
			int Pixel = Matrix.Pixel;
			int Offset = Matrix.Offset;

			Bitmap TempBmp = (Bitmap)bmp.Clone();

			BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
			BitmapData TempBmpData = TempBmp.LockBits(new Rectangle(0, 0, TempBmp.Width, TempBmp.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);


			try
			{
				unsafe
				{
					byte* ptr = (byte*)bmpData.Scan0.ToPointer();
					byte* TempPtr = (byte*)TempBmpData.Scan0.ToPointer();

					int Pix = 0;
					int Stride = bmpData.Stride;
					int DoubleStride = Stride * 2;
					
					int stopAddress = (int)ptr + bmpData.Stride * (bmpData.Height -2);

					while ((int)ptr < stopAddress - 6)
						{
							Pix = (((((TempPtr[2] * TopLeft) + (TempPtr[5] * TopMid) + (TempPtr[8] * TopRight)) +
							  ((TempPtr[2 + Stride] * MidLeft) + (TempPtr[5 + Stride] * Pixel) + (TempPtr[8 + Stride] * MidRight)) +
							  ((TempPtr[2 + DoubleStride] * BottomLeft) + (TempPtr[5 + DoubleStride] * BottomMid) + (TempPtr[8 + DoubleStride] * BottomRight))) / Factor) + Offset);

							Pix = Math.Max(0, Math.Min(255, Pix));

							ptr[5 + Stride] = (byte)Pix;

							Pix = (((((TempPtr[1] * TopLeft) + (TempPtr[4] * TopMid) + (TempPtr[7] * TopRight)) +
								  ((TempPtr[1 + Stride] * MidLeft) + (TempPtr[4 + Stride] * Pixel) + (TempPtr[7 + Stride] * MidRight)) +
								  ((TempPtr[1 + DoubleStride] * BottomLeft) + (TempPtr[4 + DoubleStride] * BottomMid) + (TempPtr[7 + DoubleStride] * BottomRight))) / Factor) + Offset);

							Pix = Math.Max(0, Math.Min(255, Pix));

							ptr[4 + Stride] = (byte)Pix;

							Pix = (((((TempPtr[0] * TopLeft) + (TempPtr[3] * TopMid) + (TempPtr[6] * TopRight)) +
								  ((TempPtr[0 + Stride] * MidLeft) + (TempPtr[3 + Stride] * Pixel) + (TempPtr[6 + Stride] * MidRight)) +
								  ((TempPtr[0 + DoubleStride] * BottomLeft) + (TempPtr[3 + DoubleStride] * BottomMid) + (TempPtr[6 + DoubleStride] * BottomRight))) / Factor) + Offset);

							Pix = Math.Max(0, Math.Min(255, Pix));

							ptr[3 + Stride] = (byte)Pix;

							ptr += 3;
							TempPtr += 3;
						}
				}
			}
			finally
			{
				bmp.UnlockBits(bmpData);
				TempBmp.UnlockBits(TempBmpData);
			}


		}

		public ConvolutionMatrix Matrix { get; set; }
	}


}
