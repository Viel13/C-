using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    abstract class Conta
    {
        public int Agencia { get; set; }
        public DateTime DataNasc { get; set; }
       public int Numero { get; set; }
        public decimal Saldo { get; set; }

       
        public abstract void Depositar(decimal valor);

        public abstract void Retirar(decimal valor);
                   
               

        public Conta(int agencia, DateTime dataNasc, int numero, decimal saldo)
        {
            Agencia = agencia;
            DataNasc = dataNasc;
            Numero = numero;
            Saldo = saldo;
        }

        public TipoConta TipoConta { get; set; }

        


    }
}
