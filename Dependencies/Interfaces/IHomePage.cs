namespace Dependencies.Interfaces
{
    public interface IHomePage
    {
        void enterSearchTerm(string searchTerm);
        ISearchResults clickSearchButton();
        ICategoryPage clickSearchForCategory();
        void selectCategory(string categoryName);
        void launchSite(string url);
    }
}
