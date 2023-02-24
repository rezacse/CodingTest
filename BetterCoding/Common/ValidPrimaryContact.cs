using BetterCoding.Interfaces;

namespace BetterCoding.Common
{
    internal class ValidPrimaryContact : IPrimaryContactState
    {
        private IContactInfo Contact { get; }
        private Func<IContactInfo, bool> Predicate { get; }
        public ValidPrimaryContact(IContactInfo contact, Func<IContactInfo, bool> predicate)
        {
            if (contact == null) throw new ArgumentNullException(nameof(contact));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));
            if (!predicate(contact)) throw new ArgumentNullException(nameof(predicate));


            Contact = contact;
            Predicate = predicate;
        }

        public IContactInfo Get() => this.Contact;

        public IPrimaryContactState Set(IContactInfo contact)
            => new ValidPrimaryContact(contact, this.Predicate);
    }
}
