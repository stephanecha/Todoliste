using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mail

{
    public class PieceJointe

    {
        public Email Email { get; set; }

        public DateTime DateAjout { get; set; }

        public List<FileInfo> Files { get; set; }

    }

    public class FileInfo //cette class n'est pas sasns doute pas necessaire si l'on precise ce "using System.IO"
    {
        public FileInfo File;
    }
}