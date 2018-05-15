using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dependencies.Interfaces;

namespace Framework.PageClasses
{
    public class AuthorPage : IAuthorPage
    {
        public AuthorPage()
        {
        }

        public string authorDescription()
        {
            throw new NotImplementedException();
        }

        public List<string> getListOfAuthorsOnPage()
        {
            throw new NotImplementedException();
        }
    }
}
