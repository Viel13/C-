using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exerciocio.Model
{
    abstract class Conta
    {
        private int Agencia { get; set; }
        private DateTime DataNasc { get; set; }
        private int Numero { get; set; }
        private double Saldo { get; set; }

       
        public abstract void Depositar();

        public virtual void Retirar()
        {
            Console.WriteLine("Saiu o seu dinheiro");

        }

        public Conta(int agencia, DateTime dataNasc, int numero, double saldo)
        {
            Agencia = agencia;
            DataNasc = dataNasc;
            Numero = numero;
            Saldo = saldo;
        }

        public TipoConta TipoConta { get; set; }

        


    }
}
