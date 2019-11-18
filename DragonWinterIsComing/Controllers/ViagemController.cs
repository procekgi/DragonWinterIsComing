using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DragonWinterIsComing.DAL;
using DragonWinterIsComing.Models;
using Microsoft.AspNetCore.Mvc;

namespace DragonWinterIsComing.Controllers
{
    public class ViagemController : Controller
    {
        private readonly ViagemDAO _viagemDAO;
        public ViagemController(ViagemDAO viagemDAO)
        {
            _viagemDAO = viagemDAO;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AvaliacaoViagem(Viagem v)
        {
            return View();
        }

        public IActionResult AdicionarNota(Viagem v)
        {
            v.Piloto.Status = "Livre";
            v.Status = "Encerrada";
            v.Piloto.Cidade = v.LocDestino;
            //v.Piloto.QuantidadeViagens++;
            _viagemDAO.AdicionarNota(v);

            return View();
        }

        public IActionResult CadastroViagem()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarViagem(Viagem v)
        {
            ViewBag.DataHora = DateTime.Now;
            if (ModelState.IsValid)
            {
                _viagemDAO.CadastrarViagem(v);
            }
                
                return View();
            
        }
    }
}