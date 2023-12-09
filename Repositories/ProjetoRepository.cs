using Exo.WebApi.Contexts;
using Exo.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exo.WebApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly ExoContext _context;

        public ProjetoRepository(ExoContext context)
        {
            _context = context;
        }

        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        // Adicione métodos para criar, atualizar e excluir projetos, se necessário.
        // Exemplos:

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(Projeto projeto)
        {
            _context.Projetos.Update(projeto);
            _context.SaveChanges();
        }

        public void Deletar(int projetoId)
        {
            var projeto = _context.Projetos.Find(projetoId);
            if (projeto != null)
            {
                _context.Projetos.Remove(projeto);
                _context.SaveChanges();
            }
        }
    }
}
