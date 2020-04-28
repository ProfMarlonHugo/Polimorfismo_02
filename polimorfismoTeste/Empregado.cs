using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTeste
{
    class Empregado : Pessoa
    {
        public override string Imprimir()
        {
            return nome;
        }
    }
}
