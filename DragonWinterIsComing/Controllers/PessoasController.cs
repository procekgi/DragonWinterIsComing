using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DragonWinterIsComing.Models;
using DragonWinterIsComing.DAL;
using System.Net;
using Newtonsoft.Json;

namespace DragonWinterIsComing.Controllers
{
    public class PessoasController : Controller
    {
        private readonly PessoaDAO _pessoaDAO;
        private readonly ViagemDAO _viagemDAO;

        public PessoasController(PessoaDAO pessoaDAO, ViagemDAO viagemDAO)
        {
            _pessoaDAO = pessoaDAO;
            _viagemDAO = viagemDAO;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult EntrarUsuario()
        {
            return RedirectToAction("PaginaUsuario");
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

        public IActionResult PaginaUsuario(Usuario u, Viagem v)
        {           
           return View(_viagemDAO.ListarViagens(v));                       
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

        //[HttpPost]
        //public IActionResult BuscarPessoa(Pessoa p)
        //{
        //    try
        //    {
        //        string url = "https://anapioficeandfire.com/" + p.Genero + "/json/";
        //        WebClient client = new WebClient();
        //        p.Genero = JsonConvert.DeserializeObject<Pessoa>(client.DownloadString(url));
        //        TempData["Pessoa"] = JsonConvert.SerializeObject(p);
        //    }
        //    catch (Exception)
        //    {
        //        //Mostrar uma mensagem para o usuário
        //    }
        //    return RedirectToAction("Cadastrar");
        //}

    }
}
