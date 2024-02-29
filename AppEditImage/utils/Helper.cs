using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEditImage.utils
{
    static class Helper
    {
        public static Rectangle GetIntersectionRect(Rectangle a, Rectangle b)
        {
            //Tính toán ranh giới bên trái và bên phải của phần giao nhau
            int left = Math.Max(a.Left, b.Left);
            int right = Math.Min(a.Right, b.Right);

            //Tính toán ranh giới phía trên và phía dưới của phần giao nhau
            int top = Math.Max(a.Top, b.Top);
            int bottom = Math.Min(a.Bottom, b.Bottom);

            // Kiểm tra xem phần giao nhau  có hợp lệ không (chiều rộng và chiều cao là số dương)
            if (right <= left || bottom <= top)
            {
                return Rectangle.Empty; // Không có phần giao nhau
            }

            // Trả về hình chữ nhật giao nhau
            return new Rectangle(left, top, right - left, bottom - top);
        }
    }
}
