using System.Diagnostics.Contracts;
using BetterCoding.Builders.Machine.Contracts;

namespace BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ModelHolderContracts))]
    public interface IModelHolder
    {
        IOwned WithModel(string model);
    }
}