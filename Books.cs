using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsPractice
{
    class Books
    {

        public string title;
        public string author;
        public int pages;

        public Books()
        {

        }

        public Books(string aAuthor, string aTitle, int aPages)
        {
           
            author = aAuthor;
            title = aTitle;
            pages = aPages;
        }

    }
}
