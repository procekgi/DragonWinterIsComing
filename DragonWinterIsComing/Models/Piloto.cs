using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.Models
{
    [Table("Pilotos")]
    public class Piloto : Pessoa
    {

       
        public string Cdh { get; set; }



        
        public Dragao Dragao { get; set; }



        
        public string Status { get; set; }



        
        
        public double PilotoMedia { get; set; }


    }
}
