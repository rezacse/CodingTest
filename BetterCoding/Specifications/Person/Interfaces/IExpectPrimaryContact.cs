using BetterCoding.Interfaces;

namespace BetterCoding.Specifications.Person.Interfaces
{
    public interface IExpectPrimaryContact
    {
        IExpectAlternateContact WithPrimaryContact<T>(IBuildingSpecification<T> primaryContactSpec)
            where T : IContactInfo;
    }
}