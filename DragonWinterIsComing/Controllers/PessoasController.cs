using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DragonWinterIsComing.Models;
using DragonWinterIsComing.DAL;

namespace DragonWinterIsComing.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaDAO _pessoaDAO;

        public PessoasController(PessoaDAO pessoaDAO)
        {
            _pessoaDAO = pessoaDAO;
        }

        public IActionResult Login()
        {
            return View();
        }

        //public bool Login()
        //{

        //}

        public IActionResult CadastroUsuario()
        {
            return View();
        }
        public IActionResult CadastroPiloto()
        {
            return View();
        }

        public IActionResult PaginaPiloto(Piloto p)
        {
            return View();
        }

        public IActionResult PaginaUsuario(Usuario u)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Piloto p, Usuario u)
        {
            if (!string.IsNullOrEmpty(p.Cdh))
            {
                //Piloto
                if (ModelState.IsValid)
                {
                    if (_pessoaDAO.Cadastrar(p))
                    {
                        return RedirectToAction("PaginaPiloto");

                    }

                }
                ModelState.AddModelError("", "Hoo man, já existe esse cadastro!");
                return View(p);
            }
            else
            {
                //Usuário
                if (ModelState.IsValid)
                {
                    if (_pessoaDAO.Cadastrar(u))
                    {
                        return RedirectToAction("PaginaUsuario");

                    }

                }
                ModelState.AddModelError("", "Hoo man, já existe esse cadastro!");
                return View(u);
            }
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_pessoaDAO.ListarPessoas());

        }

        public IActionResult Alterar(int id)
        {
            return View(_pessoaDAO.BuscarPorPessoaId(id));
        }

    }
}
