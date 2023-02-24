namespace BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectEmailAddress
    {
        IExpectPhoneNumber WithEmailAddress(IBuildingSpecification<Models.EmailAddress> emailSpec);
    }
}