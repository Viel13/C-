using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        private readonly decimal _rendimento;

        public decimal Taxa { get; set; }


        public ContaPoupanca(int agencia, DateTime dataNasc, int numero, decimal saldo, decimal red) : base(agencia, dataNasc, numero, saldo)
        {
            _rendimento = red;
        }

        
        
      

        
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Retirar(decimal valor)
        {
            if(Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            }
            Saldo -= valor;
        }

        public decimal EstorouOLimite()
        {
            return Saldo * _rendimento;
        }
    }
}
