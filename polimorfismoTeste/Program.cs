using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polimorfismoTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            // polimorfismo parametrico
            ListaDinamica obj = new ListaDinamica();
            List<int> numeros = obj.CriarLista<int>(1, 2, 3, 4, 5, 6, 10, 11, 12 );
            List<string> nomes = obj.CriarLista<string>("Marlon", "Leandro", "João");
            List<double> dec = obj.CriarLista<double>(1.1, 1.2, 2.2);
          

           
            //Polimorfismo por inclusao
            Empregado e = new Empregado();
            e.setNome("Marlon");

            Mostrar m = new Mostrar();
            m.imprimirNaTela(e);

            Console.ReadKey();
        }
    }
}
