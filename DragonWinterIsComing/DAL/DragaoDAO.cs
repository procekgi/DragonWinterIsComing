using DragonWinterIsComing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.DAL
{
    public class DragaoDAO 
    {
        private readonly Context _context;
        public DragaoDAO(Context context) => _context = context;

        //Método de cadastro
        public bool Cadastrar(Dragao d)
        {
            if (BuscarDragaoPorNome(d) == null)
            {
                _context.Dragoes.Add(d);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        //Buscar por nome
        public Dragao BuscarDragaoPorNome(Dragao d)
        {
            return _context.Dragoes.FirstOrDefault
                (x => x.Nome.Equals(d.Nome));
        }

        //Buscar por Id
        public Dragao BuscarPorDragaoId(int idDragao)
        {
            return _context.Dragoes.Find(idDragao);
        }

        //Lista de Dragões
        public List<Dragao> ListarDragoes()
        {
            return _context.Dragoes.ToList();
        }

        //Alterar Dados do Dragão
        public void AlterarDadosDragao(Dragao d)
        {
            _context.Dragoes.Update(d);
            _context.SaveChanges();
        }

        //Excluir Dragão
        public void ExcluirDragao (int Id)
        {
            _context.Dragoes.Remove(BuscarPorDragaoId(Id));
            _context.SaveChanges();
        }
    }
}
