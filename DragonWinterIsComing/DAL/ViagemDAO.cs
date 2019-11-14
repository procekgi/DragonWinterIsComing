
using DragonWinterIsComing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.DAL
{    
    public class ViagemDAO
    {
        private readonly Context _context;
        public ViagemDAO(Context context)
        {
            _context = context;
        }
        public void AdicionarNota(Viagem v)
        {
            _context.Entry(v).State = EntityState.Modified;
            _context.SaveChanges();

        }
        public void CadastrarViagem(Viagem v)
        {
            _context.Viagens.Add(v);
            _context.SaveChanges();
        }

    }
}
