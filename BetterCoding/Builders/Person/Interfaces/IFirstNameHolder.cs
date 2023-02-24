using BetterCoding.Builders.Person.Contracts;
using System.Diagnostics.Contracts;

namespace BetterCoding.Builders.Person.Interfaces
{
    [ContractClass(typeof(FirstNameHolderContracts))]
    public interface IFirstNameHolder
    {
        ILastNameHolder WithFirstName(string name);
        [Pure]
        bool IsValidFirstName(string name);
    }
}
