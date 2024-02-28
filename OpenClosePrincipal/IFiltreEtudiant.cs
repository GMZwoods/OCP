using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal interface IFiltre<T> 
    {
        List<T> AFiltrer(List<T> l, ICritère<T> e);
    }
}
