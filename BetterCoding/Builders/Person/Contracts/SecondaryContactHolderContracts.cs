using System.Diagnostics.Contracts;
using BetterCoding.Builders.Person.Interfaces;
using BetterCoding.Interfaces;

namespace BetterCoding.Builders.Person.Contracts
{
    [ContractClassFor(typeof(ISecondaryContactHolder))]
    public abstract class SecondaryContactHolderContracts : ISecondaryContactHolder
    {

        public abstract bool Contains(IContactInfo contact);

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact)
        {
            Contract.Requires(contact != null);
            Contract.Requires(!Contains(contact));
            return null;
        }

        public abstract IPersonBuilder AndNoMoreContacts();

    }
}