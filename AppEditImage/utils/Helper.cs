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
            // Calculate the left and right bounds of the intersection
            int left = Math.Max(a.Left, b.Left);
            int right = Math.Min(a.Right, b.Right);

            // Calculate the top and bottom bounds of the intersection
            int top = Math.Max(a.Top, b.Top);
            int bottom = Math.Min(a.Bottom, b.Bottom);

            // Check if the intersection is valid (width and height are positive)
            if (right <= left || bottom <= top)
            {
                return Rectangle.Empty; // No intersection
            }

            // Return the intersection rectangle
            return new Rectangle(left, top, right - left, bottom - top);
        }
    }
}
