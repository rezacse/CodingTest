using BetterCoding.Interfaces;

namespace BetterCoding.Common
{
    internal class UninitializedPrimaryContact : IPrimaryContactState
    {
        private Func<IContactInfo, bool> Predicate { get; }

        public UninitializedPrimaryContact(Func<IContactInfo, bool> predicate)
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            Predicate = predicate;
        }

        public IContactInfo Get()
        {
            throw new NotImplementedException();
        }

        public IPrimaryContactState Set(IContactInfo contact)
        {
            return new ValidPrimaryContact(contact, this.Predicate);
        }
    }
}
