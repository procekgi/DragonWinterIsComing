using DragonWinterIsComing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DragonWinterIsComing.DAL
{
    public class PessoaDAO
    {
        private readonly Context _context;
        public PessoaDAO(Context context) => _context = context;

        //Método de cadastro
        public bool Cadastrar(Pessoa p)
        {
            if (BuscarPessoaPorNome(p) == null)
            {
                _context.Pessoas.Add(p);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        //Buscar por nome
        public Pessoa BuscarPessoaPorNome(Pessoa p)
        {
            return _context.Pessoas.FirstOrDefault
                (x => x.Nome.Equals(p.Nome));
        }

        //Buscar por Id
        public Pessoa BuscarPorPessoaId(int Id)
        {
            return _context.Pessoas.Find(Id);
        }

        //Lista de Pessoas
        public List<Pessoa> ListarPessoas()
        {
            return _context.Pessoas.ToList();
        }

        //Alterar Dados do Pessoa
        public void AlterarDadosPessoa(Pessoa p)
        {
            _context.Pessoas.Update(p);
            _context.SaveChanges();
        }

    }
}
