namespace Brick
{
    class Aperture
    {
        private int width;
        private int height;

        public Aperture()
        {
            width = 10;
            height = 15;
        }

        public Aperture(int width, int height)
        {
            this.width = width;
            this.height = height;
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
    }
}
