using BetterCoding.Specifications.EmailAddress;
using BetterCoding.Specifications.PhoneNumber;
using BetterCoding.Specifications.PhoneNumber.Interfaces;

namespace BetterCoding.Specifications.ContactInfo
{
    public static class ContactSpecification
    {
        public static IBuildingSpecification<Models.EmailAddress> ForEmailAddress(string emailAddress) =>
            EmailAddressSpecification.Initialize().WithAddress(emailAddress);

        public static IExpectCountryCode ForPhoneNumber() =>
            PhoneNumberSpecification.Initialize();
    }
}
