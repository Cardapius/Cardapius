﻿namespace BuildingBlock.Domain.Rules
{
    public interface IBusinessRule
    {
        bool IsBroken();

        string Message { get; }
    }
}
