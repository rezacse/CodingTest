namespace BetterCoding.Specifications.Person.Interfaces
{
    public interface IExpectSurname
    {
        IExpectPrimaryContact WithSurname(string surname);
    }
}