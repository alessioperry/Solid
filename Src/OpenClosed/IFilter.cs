using System.Collections.Generic;

namespace OpenClosed
{
    public interface IFilter<T>
    {
        IEnumerable<T> Apply(IEnumerable<T> ienumerableToFilter, ISpecification<T> specification);
    }
}