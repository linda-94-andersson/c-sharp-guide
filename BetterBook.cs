using System;
using System.Data;
using System.Dynamic;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace HelloWorld
{
    class  BetterBook
    {
        public string title;
        public string author;
        public int pages; 

        public BetterBook(string aTitle, string aAuthor, int aPages) // Constructure
        {
            title = aTitle; 
            author = aAuthor;
            pages = aPages; 
        }
    }
}