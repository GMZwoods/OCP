using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal class FiltreEtudiant : IFiltre<Etudiant>
    {
        public List<Etudiant> AFiltrer(List<Etudiant> l, ICritère<Etudiant> c)
        {
          return l.FindAll(e => c.estValide(e));
        }
    }
}
