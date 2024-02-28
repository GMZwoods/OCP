using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal class AgeCritère : ICritère<Etudiant>
    {
        public int AgeCrit { get; set; }

        public AgeCritère(int agecrit) 
        {
            AgeCrit=agecrit;
        }


        public bool estValide(Etudiant t)
        {
           return t.Age > AgeCrit;
        }
    }
}
