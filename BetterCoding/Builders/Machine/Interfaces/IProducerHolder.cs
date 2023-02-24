using System.Diagnostics.Contracts;
using BetterCoding.Builders.Machine.Contracts;
using BetterCoding.Models;

namespace BetterCoding.Builders.Machine.Interfaces
{
    [ContractClass(typeof(ProducerHolderContracts))]
    public interface IProducerHolder
    {
        IModelHolder WithProducer(Producer producer);
    }
}
