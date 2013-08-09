namespace OpenClosed
{
    public interface ISpecification<in T>
    {
        bool IsSatisfiedBy(T source);
    }
}