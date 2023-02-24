using BetterCoding.Builders.Person.Interfaces;
using System.Diagnostics.Contracts;

namespace BetterCoding.Builders.Person.Contracts
{
    [ContractClassFor(typeof(IFirstNameHolder))]
    public abstract class FirstNameHolderContracts : IFirstNameHolder
    {
        public abstract bool IsValidFirstName(string name);

        public ILastNameHolder WithFirstName(string name)
        {
            Contract.Requires(IsValidFirstName(name));
            return null;
        }
    }
}
