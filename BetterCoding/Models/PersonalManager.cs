using BetterCoding.Interfaces;

namespace BetterCoding.Models
{
    public class PersonalManager
    {
        private readonly Func<IUser> userFactory;
        public PersonalManager(Func<IUser> userFactory)
        {
            this.userFactory = userFactory;
        }

        private IContactInfo GetPrimaryContact()
        {
            return this.userFactory().PrimaryContact;
        }
        public void Notify(string message)
        {
            this.Enqueue(this.GetPrimaryContact(), message);
        }

        private void Enqueue(IContactInfo contact, string message)
        {
            Console.WriteLine($"Sending {message} to {contact}");
        }
    }
}
