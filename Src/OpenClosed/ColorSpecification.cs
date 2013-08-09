namespace OpenClosed
{
    public class ColorSpecification : ISpecification<IProduct>
    {
        private readonly string color;

        public ColorSpecification(string color)
        {
            this.color = color;
        }

        public bool IsSatisfiedBy(IProduct source)
        {
            return source.Color() == color;
        }
    }
}