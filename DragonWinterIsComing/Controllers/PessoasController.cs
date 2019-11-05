﻿using System;
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

        public IActionResult CadastrarPessoa()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(Pessoa p)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            ModelState.AddModelError("" ,"Hoo man, já existe esse cadastro!");
            return View(p);
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_pessoaDAO.ListarPessoas());
            
        }


        

    }
}