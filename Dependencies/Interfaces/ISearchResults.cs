namespace Dependencies.Interfaces
{
    public interface ISearchResults
    {
        string firstResultTitle();
        string firstResultAuthor();
        string firstResultPrice();
        IAuthorPage clickAuthorLink();
    }
}
