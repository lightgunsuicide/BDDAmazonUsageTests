namespace Dependencies.Interfaces
{
    public interface ISearchResults
    {
        string firstResultTitle();
        string firstResultAuthor();
        decimal firstResultPrice();
        IAuthorPage clickAuthorLink();
    }
}
