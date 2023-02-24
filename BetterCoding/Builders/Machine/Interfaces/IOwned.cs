using System.Diagnostics.Contracts;
using BetterCoding.Builders.Machine.Contracts;
using BetterCoding.Models;

namespace BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(OwnedContracts))]
    public interface IOwned
    {
        IMachineBuilder OwnedBy(LegalEntity company);
    }
}