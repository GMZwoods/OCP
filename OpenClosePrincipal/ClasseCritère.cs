using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal class ClasseCritère : ICritère<Etudiant>
    {
        public string  CoursSuivi { get; set; }
        public ClasseCritère(string courssuivi) 
        {
            CoursSuivi = courssuivi;
        
        }

        public bool estValide(Etudiant t)
        {
            return t.Classes == CoursSuivi;
        }
    }


}
