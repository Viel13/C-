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
            ContaCorrente cs = new ContaCorrente(123, DateTime.Now, 1234, 100.10m)
            {
                TipoConta1 = TipoConta.COMUN
            };

           

        ContaPoupanca cp = new ContaPoupanca(124, DateTime.Now, 1235, 20000.0m, 1000.0m);

            cp.Depositar(1000.0m);

            

        }
    }
}
