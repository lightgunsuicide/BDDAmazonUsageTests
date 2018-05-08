using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.PageClasses.Interfaces
{
    public interface ISearchResults
    {
        string firstResultTitle();
        string firstResultAuthor();
        decimal firstResultPrice();
        IAuthorPage clickAuthorLink();
    }
}
