﻿namespace BetterCoding.Common
{
    internal interface INonEmptyStringState
    {
        INonEmptyStringState Set(string value);
        string Get();
    }
}
