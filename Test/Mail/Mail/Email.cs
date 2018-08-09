//Diag de classe UML, voir les acces et relations
/* 
 Ecrire la classe Email
 Ecrire la classe piece jointe (la classe FileInfo est une classe.Net dans l'espace de nom System.IO
 */


using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.IO;



namespace Mail

{
    private Main (String[] args);

            public class Email

        {
            public string Sujet { get; set; }

            public string Destinataire { get; set; }

            public string[] DestinatairesEnCopie { get; set; }

            public string Contenu { get; set; }

            //(cardinalité : 0...* ) signifit qu'il peut y avoir de 0 à x pj, possible, par email | la relation est precisé du côté email via un losange plein.
            public List<PieceJointe> PieceJointe { get; set; }

        }

}