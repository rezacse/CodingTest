using BetterCoding.Builders.Person.Interfaces;
using BetterCoding.Interfaces;

namespace BetterCoding.Builders.Person
{
    public class PersonBuilder :
        IFirstNameHolder, ILastNameHolder, IPrimaryContactHolder,
        ISecondaryContactHolder, IPersonBuilder
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private IContactInfo PrimaryContact { get; set; }
        private IList<IContactInfo> Contacts { get; set; } = new List<IContactInfo>();

        public static IFirstNameHolder Person() => new PersonBuilder();

        public bool IsValidFirstName(string name) => !string.IsNullOrEmpty(FirstName);
        public ILastNameHolder WithFirstName(string name)
            => new PersonBuilder { FirstName = name };

        public bool IsValidLastName(string surname) => !string.IsNullOrEmpty(LastName);
        public IPrimaryContactHolder WithLastName(string surname)
            => new PersonBuilder
            {
                FirstName = this.FirstName,
                LastName = surname
            };

        public ISecondaryContactHolder WithPrimaryContact(IContactInfo contact)
            => new PersonBuilder
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                PrimaryContact = contact,
                Contacts = new List<IContactInfo>(this.Contacts) { contact },
            };

        public ISecondaryContactHolder WithSecondaryContact(IContactInfo contact)
            => new PersonBuilder
            {
                FirstName = this.FirstName,
                LastName = this.LastName,
                PrimaryContact = this.PrimaryContact,
                Contacts = new List<IContactInfo>(this.Contacts) { contact },
            };

        public IPersonBuilder AndNoMoreContacts() => this;

        public bool Contains(IContactInfo contact) => this.Contacts.Contains(contact);


        public Models.Person Build()
        {
            var person = new Models.Person();
            person.Name= this.FirstName;
            person.Surname= this.LastName;
            person.PrimaryContact= this.PrimaryContact;
            foreach (IContactInfo contact in this.Contacts)
                person.ContactsList.Add(contact);

            return person;

        }
    }
}
