using System.Collections.Generic;
using System.Linq;

namespace OpenClosed
{
    public interface IPredicate<in T>
    {
        bool Apply(T objectSource);
    }

    public interface IErrorProductFilter
    {
        IEnumerable<IProduct> Filter(IEnumerable<IProduct> fullList, IPredicate<IProduct> predicate);
    }

    public class TestPredicate : IPredicate<IProduct>
    {
        //this class it is not good beco
        private readonly IProduct product;

        public TestPredicate(IProduct product)
        {
            this.product = product;
        }

        public bool Apply(IProduct objectSource)
        {
            return objectSource.Color() == product.Color();
        }
}

    public class ErrorProductFilter
    {
        public IEnumerable<IProduct> GetItemsMatchingTheColor(IEnumerable<IProduct> fullList, string color)
        {
            return fullList.Where(item => item.Color() == color);
        }

        // Added this new method…
        public IEnumerable<IProduct> GetItemsMatchingSomeSize(IEnumerable<IProduct> fullList, string size)
        {
            return fullList.Where(item => item.Size() == size);
        }

        // Added this new method…
        public IEnumerable<IProduct> GetItemsMatchingSomeSizeAndTheColor(IEnumerable<IProduct> fullList, string size, string color)
        {
            return fullList.Where(item => (item.Size() == size && item.Color() == color));
        }

    }

    public class TheTest
    {
        public void DoTheWork()
        {
            var productList = new List<IProduct>
            {
                new Product("red", "1"),
                new Product("blue", "1"),
                new Product("white", "1"),
                new Product("red", "2"),
                new Product("viola", "3"),
                new Product("black", "3"),
                new Product("red", "4"),
                new Product("brown", "4")
            };

            var filter = new ProductFilter();

            var filterByClor = filter.Apply(productList, new ColorSpecification("red"));
            var filterdBySize = filter.Apply(productList, new SizeSpecification("2"));
        }

    }

}
