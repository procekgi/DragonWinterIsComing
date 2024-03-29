﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.Models
{

    [Table("Pessoas")]
    public class Pessoa
    {
        public Pessoa() { CriadoEm = DateTime.Now; }
        [Key]
        public int PessoaId { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        public string Genero { get; set; }
        public string Cultura { get; set; }
        public string Nascimento { get; set; }
        public string Apelido { get; set; }
           
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Senha { get; set; }


        [Required(ErrorMessage = "Campo obrigatório")]
        public string ComparacaoSenha { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; }
        
        public int Tipo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Casa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Cidade { get; set; }
                     

        public DateTime CriadoEm { get; set; }
    }
}

