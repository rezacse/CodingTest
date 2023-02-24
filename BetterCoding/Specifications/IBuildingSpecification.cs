﻿namespace BetterCoding.Specifications
{
    public interface IBuildingSpecification<T> 
        : IEquatable<IBuildingSpecification<T>>
    {
        T Build();


    }
}
