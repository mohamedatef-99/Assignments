using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03.Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle(Book B)
        {
            return B.Title;
        }
        public static string GetAuthors(Book b)
        {
            return b.Authors;
        }
        public static decimal GetPrice(Book b)
        {
            return b.Price;
        }
        public static DateTime GetPublicationDate(Book b)
        {
            return b.PublicationDate;
        }
        public static string GetISBN(Book b)
        {
            return b.ISBN;
        }
    }
}
