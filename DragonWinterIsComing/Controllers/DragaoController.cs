using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DragonWinterIsComing.Models;
using DragonWinterIsComing.DAL;

namespace DragonWinterIsComing.Controllers
{
    public class DragaoController : Controller
    {
        private readonly DragaoDAO _dragaoDAO;

        public DragaoController(DragaoDAO dragaoDAO)
        {
            _dragaoDAO = dragaoDAO;
        }


        public IActionResult CadastrarDragao()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Cadastrar(Dragao d)
        {
            if (ModelState.IsValid)
            {
                if (_dragaoDAO.Cadastrar(d))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError("", "Hoo man, este dragão já está cadastrado!!!");
                return View(d);
            }
            return View(d);
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_dragaoDAO.ListarDragoes());
        }

        public IActionResult ExcluirDragao(int Id)
        {
            _dragaoDAO.ExcluirDragao(Id);
            return RedirectToAction("Index");
        }

        public IActionResult AlterarDadosDragao(Dragao d)
        {
            _dragaoDAO.AlterarDadosDragao(d);
            return RedirectToAction("Index");
        }

       

    }
}
