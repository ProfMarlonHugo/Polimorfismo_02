using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTeste
{
    public abstract class  Pessoa
    {
        public string nome;
        public void setNome(string n)
        {
            nome = n;
        }
        public abstract string Imprimir();
    }
}
