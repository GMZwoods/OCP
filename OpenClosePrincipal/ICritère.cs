using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrincipal
{
    internal interface ICritère<T>
    {    // <T> est pour indiquer que la valeur est de type génériques et "t" est le NOM de la variable "T" (dans ce cas, c'est le type générique)
         bool estValide(T t);


    }
}
