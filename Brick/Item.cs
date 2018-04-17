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

        public int Width { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }
    }
}