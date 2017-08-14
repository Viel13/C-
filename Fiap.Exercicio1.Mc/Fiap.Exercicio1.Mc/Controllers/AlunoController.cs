using Fiap.Exercicio1.Mc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercicio1.Mc.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        // GET: Aluno
        public ActionResult Cadastro()
        {
            return View();
        }

        [HttpPost]
        //Action para cadastrar as informações
        public ActionResult Salvar(Aluno aluno)
        {

            ViewBag.nomeAluno = aluno.Nome;
            ViewBag.dtaAluno = aluno.DtaNasc;
            ViewBag.salaAluno = aluno.Salary;

            TempData["mensagem"] = "Aluno Registrado!";
            return View(aluno);
            
            //   return Content("Gravooooooooooooooooooou" + aluno.nome + " " + aluno.dtaNasc + " " + aluno.salary);
        }

    }
}