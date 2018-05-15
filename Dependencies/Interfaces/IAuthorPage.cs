using System.Collections.Generic;

namespace Dependencies.Interfaces
{
    public interface IAuthorPage
    {
        List<string> getListOfAuthorsOnPage();
        string authorDescription();
    }
}
