using System.Collections.Generic;

namespace Framework.PageClasses.Interfaces
{
    public interface IAuthorPage
    {
        List<string> getListOfAuthorsOnPage();
        string authorDescription();
    }
}
