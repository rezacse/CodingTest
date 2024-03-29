﻿namespace BetterCoding.Specifications.Machine.Interfaces
{
    public interface IExpectProducer
    {
        IExpectModel ProducedBy(IBuildingSpecification<Models.Producer> producerSpec);
    }
}