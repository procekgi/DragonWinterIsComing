using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.Models
{
    [Table("Viagem")]
    public class Viagem
    {
        public Viagem() { }
        [Key]
        public int IdViagem { get; set; }
        public string LocOrigem { get; set; }
        public string LocDestino { get; set; }
        public DateTime Data { get; set; }
        public Usuario Usuario { get; set; }
        public Piloto Piloto { get; set; }
        public double Nota { get; set; }
        public Dragao Dragao { get; set; }
        public string Status { get; set; }
        public bool PossuiBagagem { get; set; }

    }
}
