using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03
{
    internal class EBook : Book
    {
        #region Properties
        public double FileSize { get; set; }
        #endregion

        #region Constructors
        public EBook(string title, string author, int isbn, double fileSize): base(title, author, isbn)
        {
            FileSize = fileSize;
        }
        #endregion

        #region Methods
        public override string DisplayInfo()
        {
            return $"{base.DisplayInfo()}, File Size: {FileSize} MB";
        }
        #endregion
    }
}
