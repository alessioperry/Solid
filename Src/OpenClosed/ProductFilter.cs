using System.Collections.Generic;
using System.Linq;

namespace OpenClosed
{
    public class ProductFilter : IFilter<IProduct>
    {
        public IEnumerable<IProduct> Apply(IEnumerable<IProduct> ienumerableToFilter, ISpecification<IProduct> specification)
        {
            return ienumerableToFilter.Where(specification.IsSatisfiedBy);
        }
    }
}