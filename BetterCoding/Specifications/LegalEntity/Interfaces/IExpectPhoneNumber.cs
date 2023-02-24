namespace BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectPhoneNumber
    {
        IExpectOtherContact WithPhoneNumber(IBuildingSpecification<Models.PhoneNumber> phoneSpec);
    }
}