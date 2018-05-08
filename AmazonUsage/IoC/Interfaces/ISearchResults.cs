namespace BDD.IoC.Interfaces
{
    public interface ISearchResults
    {
        string firstResultTitle();
        string firstResultAuthor();
        decimal firstResultPrice();
        IAuthorPage clickAuthorLink();
    }
}
