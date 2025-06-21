using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAppRepository
{
    public partial class PDBContext
    {
        //public PDBContext(string connname= "DevConnection") :base(connname)
        //{

        //}

        private readonly ConfigClass _myLibraryService;
        public PDBContext(ConfigClass myLibraryService)
        {
            _myLibraryService = myLibraryService;
        }
    }
}
