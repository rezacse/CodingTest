﻿namespace BetterCoding.Validation.Infrastructure
{
    public class NonEmptyString : Specification<string>
    {
        public override bool IsSatisfiedBy(string obj)
            => string.IsNullOrEmpty(obj);
    }
}
