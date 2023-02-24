using BetterCoding.Interfaces;

namespace BetterCoding.Models
{
    public class MacAddress : IUserIdentity
    {
        public string NicPart { get; set; }
    }
}
