using BetterCoding.Interfaces;

namespace BetterCoding.Specifications.LegalEntity.Interfaces
{
    public interface IExpectOtherContact
    {
        IExpectOtherContact WithOtherContact<T>(IBuildingSpecification<T> contactSpec)
            where T : IContactInfo;
        IBuildingSpecification<Models.LegalEntity> AndNoMoreContacts();
    }
}