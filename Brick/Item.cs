namespace Brick
{
    class Item
    {
        private int width;
        private int height;
        private int length;

        public Item()
        {
            width = 3;
            height = 5;
            length = 7;
        }

        public Item(int width, int height, int length)
        {
            this.width = width;
            this.height = height;
            this.length = length;
        }

        public int Width
        {
            get => width;
            set => width = value;
        }
        public int Height
        {
            get => height;
            set => height = value;
        }
        public int Length
        {
            get => length;
            set => length = value;
        }
    }
}