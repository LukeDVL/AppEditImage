using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEditImage.utils
{
    public class LightState
    {
        private static LightState EmptyState;
        public Bitmap OriginalImage { get; }
        public int Brightness { get; set; }
        public int Contrast { get; set; }

        public int HighLight { get; set; }
        public int Shadow { get; set; }

        public LightState()
        {
            Brightness = 0;
            Contrast = 0;
            HighLight = 0;
            Shadow = 0;
            OriginalImage = null;
        }

        public LightState(Bitmap img)
        {
            Brightness = 0;
            Contrast = 0;
            HighLight = 0;
            Shadow = 0;
            this.OriginalImage = img;       
        }

        public static LightState Empty()
        {
            if(EmptyState == null)
            {
                EmptyState = new LightState();
            }
            return EmptyState;
        }

        public LightState Clone()
        {
            return new LightState(this.OriginalImage)
            {
                Contrast = this.Contrast,
                Brightness = this.Brightness,
                HighLight = this.HighLight,
                Shadow = this.Shadow
            };
        }
    }

    public class HistoryItem
    {
        public Bitmap Img { get; set; }
        public LightState lightState {get; set;}
        public HistoryItem(Bitmap img)
        {
            this.Img = img;
            this.lightState = LightState.Empty();
        }

        public HistoryItem(Bitmap img, LightState lightState)
        {
            this.Img = img;
            this.lightState = lightState;
        }
    }

    public class ImageHistoryManager
    {
        private static ImageHistoryManager instance;
        public LinkedList<HistoryItem> history = new LinkedList<HistoryItem>();
        public LinkedListNode<HistoryItem> currentNode;
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
                LinkedListNode<HistoryItem> newNode = new LinkedListNode<HistoryItem>(new HistoryItem(clonedImage));

                // Nếu đây là thêm trạng thái mới, cắt bỏ các trạng thái sau hiện tại
                if (currentNode != null && currentNode.Next != null)
                {
                    // Xóa tất cả các nút từ nút tiếp theo của currentNode cho đến cuối danh sách
                    LinkedListNode<HistoryItem> nextNode = currentNode.Next;
                    while (nextNode != null)
                    {
                        LinkedListNode<HistoryItem> tempNode = nextNode.Next;
                        history.Remove(nextNode);
                        nextNode = tempNode;
                    }
                }

                // Thêm trạng thái mới vào danh sách
                history.AddLast(newNode);
                currentNode = newNode;
            }
        }

        public void SaveHistoryState(Bitmap image, LightState lightState)
        {
            if (image != null)
            {
                Bitmap clonedImage = new Bitmap(image);
                LinkedListNode<HistoryItem> newNode = new LinkedListNode<HistoryItem>(new HistoryItem(clonedImage, lightState));

                // Nếu đây là thêm trạng thái mới, cắt bỏ các trạng thái sau hiện tại
                if (currentNode != null && currentNode.Next != null)
                {
                    // Xóa tất cả các nút từ nút tiếp theo của currentNode cho đến cuối danh sách
                    LinkedListNode<HistoryItem> nextNode = currentNode.Next;
                    while (nextNode != null)
                    {
                        LinkedListNode<HistoryItem> tempNode = nextNode.Next;
                        history.Remove(nextNode);
                        nextNode = tempNode;
                    }
                }

                // Thêm trạng thái mới vào danh sách
                history.AddLast(newNode);
                currentNode = newNode;
            }
        }

        public void Undo()
        {
            if (currentNode != null && currentNode.Previous != null)
            {
                currentNode = currentNode.Previous;
                currentImage = new Bitmap(currentNode.Value.Img);
            }
        }

        public void Redo()
        {
            if (currentNode != null && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
                currentImage = new Bitmap(currentNode.Value.Img);
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
