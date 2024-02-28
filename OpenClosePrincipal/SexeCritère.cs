using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal class SexeCritère : ICritère<Etudiant>
    {
        public string SexeMoF { get; set; } 
        public SexeCritère(string sexemof) 
        {
            SexeMoF = sexemof;        
        }

        public bool estValide(Etudiant t)
        {
           return t.Sexe == SexeMoF;
        }
    }
}
