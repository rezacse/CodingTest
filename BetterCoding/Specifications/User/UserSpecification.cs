using BetterCoding.Specifications.Machine;
using BetterCoding.Specifications.Machine.Interfaces;
using BetterCoding.Specifications.Person;
using BetterCoding.Specifications.Person.Interfaces;

namespace BetterCoding.Specifications.User
{
    public static class UserSpecification
    {
        public static IExpectName ForPerson() => PersonSpecification.Initialize();
        public static IExpectProducer ForMachine() => MachineSpecification.Initialize();
    }
}
