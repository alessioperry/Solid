namespace OpenClosed
{
    public class SizeSpecification : ISpecification<IProduct>
    {
        private readonly string size;

        public SizeSpecification(string size)
        {
            this.size = size;
        }

        public bool IsSatisfiedBy(IProduct source)
        {
            return source.Size() == size;
        }
    }
}