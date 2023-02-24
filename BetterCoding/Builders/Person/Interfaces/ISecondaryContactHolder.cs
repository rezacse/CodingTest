using System.Diagnostics.Contracts;
using BetterCoding.Builders.Person.Contracts;
using BetterCoding.Interfaces;

namespace BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(SecondaryContactHolderContracts))]
    public interface ISecondaryContactHolder : IContactHolder
    {
        ISecondaryContactHolder WithSecondaryContact(IContactInfo contact);
        IPersonBuilder AndNoMoreContacts();
    }
}