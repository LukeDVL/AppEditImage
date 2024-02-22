using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEditImage.utils
{


    public class ImageHistoryManager
    {
        private static ImageHistoryManager instance;
        public LinkedList<Bitmap> history = new LinkedList<Bitmap>();
        public LinkedListNode<Bitmap> currentNode;
        public Bitmap originalImage { get; set; }
        public Bitmap currentImage { get; set; }

        private ImageHistoryManager()
        {
        }

        public static ImageHistoryManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ImageHistoryManager();
                }
                return instance;
            }
        }
        public void SaveHistoryState(Bitmap image)
        {
            if (image != null)
            {
                Bitmap clonedImage = new Bitmap(image);
                LinkedListNode<Bitmap> newNode = new LinkedListNode<Bitmap>(clonedImage);

                // Nếu đây là thêm trạng thái mới, cắt bỏ các trạng thái sau hiện tại
                if (currentNode != null && currentNode.Next != null)
                {

                    // Xóa tất cả các nút từ nút tiếp theo của currentNode cho đến cuối danh sách
                    LinkedListNode<Bitmap> nextNode = currentNode.Next;
                    while (nextNode != null)
                    {
                        LinkedListNode<Bitmap> tempNode = nextNode.Next;
                        history.Remove(nextNode);
                        nextNode = tempNode;
                    }

                }

                // Thêm trạng thái mới vào danh sách
                history.AddLast(newNode);
                currentNode = newNode;
            }
        }

        public void ClearHistory()
        {
            history.Clear();
            currentNode = null;
            originalImage = null;
            currentImage = null;
        }
    }

}
