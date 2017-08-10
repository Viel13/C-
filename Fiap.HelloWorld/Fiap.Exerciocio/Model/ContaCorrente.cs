using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int agencia, DateTime dataNasc, int numero, decimal saldo) : base(agencia, dataNasc, numero, saldo)
        {
        }

        public TipoConta TipoConta1 { get; set; }

        public override void Depositar(decimal valor)
        {
            Saldo += valor;
            
        }

        public override void Retirar(decimal valor)
        {
            if (TipoConta1 == TipoConta.COMUN && Saldo < valor)
            {
                throw new Exception("Saldo Insuficiente");
            }
            Saldo -= valor;
        }
    }
}
