﻿using BetterCoding.Specifications.PhoneNumber.Interfaces;

namespace BetterCoding.Specifications.PhoneNumber
{
    public class PhoneNumberSpecification :
        IExpectCountryCode, IExpectAreaCode,
        IExpectNumber, IBuildingSpecification<Models.PhoneNumber>
    {

        private int CountryCode { get; set; }
        private int AreaCode { get; set; }
        private int Number { get; set; }

        private PhoneNumberSpecification() { }

        public static IExpectCountryCode Initialize() => new PhoneNumberSpecification();

        public IExpectAreaCode WithCountryCode(int countryCode)
        {
            if (countryCode <= 0)
                throw new ArgumentException();

            return new PhoneNumberSpecification()
            {
                CountryCode = countryCode
            };
        }

        public IExpectNumber WithAreaCode(int areaCode)
        {
            if (areaCode <= 0)
                throw new ArgumentException();

            return new PhoneNumberSpecification()
            {
                CountryCode = CountryCode,
                AreaCode = areaCode
            };
        }

        public IBuildingSpecification<Models.PhoneNumber> WithNumber(int number)
        {
            if (number <= 0)
                throw new ArgumentException();

            return new PhoneNumberSpecification()
            {
                CountryCode = CountryCode,
                AreaCode = AreaCode,
                Number = number
            };
        }

        public Models.PhoneNumber Build() =>
            new Models.PhoneNumber()
            {
                CountryCode = CountryCode,
                AreaCode = AreaCode,
                Number = Number
            };

        public bool Equals(IBuildingSpecification<Models.PhoneNumber> other) =>
            this.Equals(other as PhoneNumberSpecification);

        private bool Equals(PhoneNumberSpecification other) =>
            other != null &&
            this.CountryCode == other.CountryCode &&
            this.AreaCode == other.AreaCode &&
            this.Number == other.Number;
    }
}
