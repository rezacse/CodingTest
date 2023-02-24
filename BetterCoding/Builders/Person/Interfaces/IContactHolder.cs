using BetterCoding.Interfaces;
using System.Diagnostics.Contracts;

namespace BetterCoding.Builders.Person.Interfaces
{
    public interface IContactHolder
    {
        [Pure]
        bool Contains(IContactInfo contact);
    }
}
