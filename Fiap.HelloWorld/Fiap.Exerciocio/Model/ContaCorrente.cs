using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, DateTime dataNasc, int numero, double saldo) : base(agencia, dataNasc, numero, saldo)
        {
        }

        public TipoConta TipoConta1 { get; set; }



        public override void Depositar()
        {
            Console.WriteLine("Seu Dinheiro Foi depositado");
        }

        public override void Retirar()
        {
            Console.WriteLine("Moto Parou");
        }
    }
}
