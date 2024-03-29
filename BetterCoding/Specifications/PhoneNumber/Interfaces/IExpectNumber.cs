﻿namespace BetterCoding.Specifications.PhoneNumber.Interfaces
{
    public interface IExpectNumber
    {
        IBuildingSpecification<Models.PhoneNumber> WithNumber(int number);
    }
}