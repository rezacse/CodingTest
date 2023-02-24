using BetterCoding.Interfaces;

namespace BetterCoding.Common
{
    internal interface IPrimaryContactState
    {
        IPrimaryContactState Set(IContactInfo contact);
        IContactInfo Get();
    }
}
