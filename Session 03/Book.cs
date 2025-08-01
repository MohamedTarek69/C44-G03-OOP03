using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class Book
    {
        #region Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }

        #endregion

        #region Constructors
        public Book(string title, string author, int isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        #endregion

        #region Methods
        public virtual string DisplayInfo()
        {
            return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}";
        }

        #endregion

    }
}
