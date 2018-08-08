using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.IO; cf ligne 21 pour commentaire

namespace Mail

{
    public class PieceJointe

    {
        public Email Email { get; set; }

        public DateTime DateAjout { get; set; }

        public FileInfo Files { get; set; }

    }

    public class FileInfo //cette class n'est pas necessaire si l'on precise ce using System.IO
    {

    }
}