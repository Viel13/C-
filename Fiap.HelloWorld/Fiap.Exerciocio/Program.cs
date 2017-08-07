using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.Exerciocio.Model;
namespace Fiap.Exerciocio
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cs = new ContaCorrente(123, DateTime.Now, 1234, 1000.10)
            {
                TipoConta1 = TipoConta.COMUN
            };

        ContaPoupanca cp = new ContaPoupanca(124, DateTime.Now, 1235, 20000.0);
           


        }
    }
}
