using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace LibCatalog
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string YearPublished { get { return DatePublished.ToString("yyyy"); }  }

        public Book(string name, string author, DateTime datePublished) 
        {
            Name = name;
            Author = author;
            DatePublished = datePublished;
        }

    }
}
