namespace OpenClosed
{
    public class Product: IProduct
    {
        private string color;
        private string size;

        public Product(string color, string size)
        {
            this.color = color;
            this.size = size;
        }

        public string Color()
        {
            return color;
        }

        public string Size()
        {
            return size;
        }
    }
}