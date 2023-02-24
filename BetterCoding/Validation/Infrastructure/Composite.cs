namespace BetterCoding.Validation.Infrastructure
{
    public class Composite<T> : Specification<T>
    {
        public Composite(Func<IEnumerable<bool>, bool> compositionFunction,
            params Specification<T>[] subspecification)
        {
            CompositionFunction = compositionFunction;
            Subspecification = subspecification;
        }

        public Func<IEnumerable<bool>, bool> CompositionFunction { get; }
        public Specification<T>[] Subspecification { get; }

        public override bool IsSatisfiedBy(T obj)
            => this.CompositionFunction(this.Subspecification.Select(s => s.IsSatisfiedBy(obj)));
    }
}
