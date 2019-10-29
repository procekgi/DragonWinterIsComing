using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.Models
{
   
        [System.ComponentModel.DataAnnotations.Schema.Table("Dragoes")]
        public class Dragao
        {
            public Dragao() { CriadoEm = DateTime.Now; }

            [Key]
            public int DragaoId { get; set; }

            
            public string Nome { get; set; }

            
            public string Raca { get; set; }

           
            public string Cor { get; set; }

           
            public string Dieta { get; set; }

            
            public string Habitat { get; set; }

            
            public string Origem { get; set; }

            
            public int Idade { get; set; }

            

            public DateTime CriadoEm { get; set; }
        }
    }

