namespace BetterCoding.Validation.Infrastructure
{
    public class NotNull<T> : Specification<T>
    {
        public override bool IsSatisfiedBy(T obj)
            => !object.ReferenceEquals(obj, null);
    }
}
