using System;
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

        
        public string Nome { get; set; }

        
        public string Cpf { get; set; }


       
        public string Senha { get; set; }


        
        public string ComparacaoSenha { get; set; }

       
        public string Email { get; set; }

       
        public int Tipo { get; set; }

      
        public string Telefone { get; set; }

       
        public string Casa { get; set; }

       
        public string Cidade { get; set; }


        
        public string Reino { get; set; }


        public DateTime CriadoEm { get; set; }
    }
    }

