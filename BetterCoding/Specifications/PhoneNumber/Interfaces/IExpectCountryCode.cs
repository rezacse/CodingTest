﻿namespace BetterCoding.Specifications.PhoneNumber.Interfaces
{
    public interface IExpectCountryCode
    {
        IExpectAreaCode WithCountryCode(int countryCode);
    }
}