using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exercicio1.Mc.Models
{
    public class Aluno
    {
        public string Nome { get; set; }

        public DateTime DtaNasc { get; set; }
        public decimal Salary { get; set; }

        public Aluno()
        {

        }
        public Aluno(string nome, DateTime dtaNasc, decimal salary)
        {
            this.Nome = nome;
            this.DtaNasc = dtaNasc;
            this.Salary = salary;
        }


    }



}