using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTeste
{
    class ListaDinamica
    {
        /*Polimorfismo parametrico*/ 
        public List<T> CriarLista<T>(params T[] P)
        {
            List<T> L = new List<T>();
            foreach (T elemento in P)
            {
                L.Add(elemento);
            }
            return L;
        }
    }
}
