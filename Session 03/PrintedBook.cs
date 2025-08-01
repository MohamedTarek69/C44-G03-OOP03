using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class PrintedBook: Book
    {
        #region Properties
        public int PageCount { get; set; }
        #endregion

        #region Constructors
        public PrintedBook(string title, string author, int isbn, int pageCount) : base(title, author, isbn)
        {
            PageCount = pageCount;
        }
        #endregion

        #region Methods
        public override string DisplayInfo()
        {
            
            return $"{base.DisplayInfo()}, Page Count: {PageCount}";
        }
        #endregion
    }
}
