using System;
using System.Diagnostics.Contracts;
using BetterCoding.Builders.Machine.Interfaces;

namespace BetterCoding.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IModelHolder))]
    public class ModelHolderContracts : IModelHolder
    {
        public IOwned WithModel(string model)
        {
            Contract.Requires<ArgumentException>(!string.IsNullOrEmpty(model));
            return null;
        }
    }
}