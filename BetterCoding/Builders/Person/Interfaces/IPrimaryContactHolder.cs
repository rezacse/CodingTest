using System.Diagnostics.Contracts;
using BetterCoding.Builders.Person.Contracts;
using BetterCoding.Interfaces;

namespace BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(PrimaryContactHolderContracts))]
    public interface IPrimaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithPrimaryContact(IContactInfo contact);
    }
}