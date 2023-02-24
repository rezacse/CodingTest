﻿using System;
using System.Diagnostics.Contracts;
using BetterCoding.Builders.Machine.Interfaces;
using BetterCoding.Models;

namespace BetterCoding.Builders.Machine.Contracts
{
    [ContractClassFor(typeof(IProducerHolder))]
    public abstract class ProducerHolderContracts : IProducerHolder
    {
        public IModelHolder WithProducer(Producer producer)
        {
            Contract.Requires<ArgumentNullException>(producer != null);
            return null;
        }
    }
}