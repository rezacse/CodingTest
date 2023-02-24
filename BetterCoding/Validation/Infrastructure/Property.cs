﻿namespace BetterCoding.Validation.Infrastructure
{
    public class Property<TType, TProperty> : Specification<TType>
    {
        public Property(Func<TType, TProperty> propertyGetter,
            Specification<TProperty> subspecification) {
            PropertyGetter = propertyGetter;
            Subspecification = subspecification;
        }

        public Func<TType, TProperty> PropertyGetter { get; }
        public Specification<TProperty> Subspecification { get; }

        public override bool IsSatisfiedBy(TType obj)
            => this.Subspecification.IsSatisfiedBy(this.PropertyGetter(obj));
    }
}
