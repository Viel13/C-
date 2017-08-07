using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private float _rendimento;

        private int Taxa { get; set; }


        public ContaPoupanca(int agencia, DateTime dataNasc, int numero, double saldo) : base(agencia, dataNasc, numero, saldo)
        {
        }

        public override void Depositar()
        {
            Console.WriteLine("Caiu a grana");
        }

        public override void Retirar()
        {
            Console.WriteLine("Ta acabando a grana");
        }

        public void EstorouOLimite()
        {
            Console.WriteLine("Jaera");
        }
    }
}
