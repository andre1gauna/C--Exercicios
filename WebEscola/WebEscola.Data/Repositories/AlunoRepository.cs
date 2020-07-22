using Escola.Data.Context;
using Escola.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebEscola.Data.Extensions;
using WebEscola.Domain.Interfaces;
using WebEscola.Domain.Models;

namespace WebEscola.Data.Repositories
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly EscolaContexto _contexto;

        public AlunoRepository(EscolaContexto contexto)
        {
            _contexto = contexto;
        }
        public int Add(Aluno entity)
        {
            _contexto.Alunos.Add(entity);
            _contexto.SaveChanges();
            return entity.Id;
        }

        public Aluno FindById(int id)
        {
            return _contexto.Alunos.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Aluno> GetAll()
        {
            return _contexto.Alunos.ToList();
        }

        Page<Aluno> IAlunoRepository.GetPage(PageFilter pageFilter, string sortingProperty)
        {

            IQueryable<Aluno> query = _contexto.Alunos;

            return OrdenarAlunos(query, sortingProperty).ToPage(pageFilter);
        }

        private IQueryable<Aluno> OrdenarAlunos(IQueryable<Aluno> query, string sortingProperty)
        {
            switch (sortingProperty.ToLower().Trim())
            {
                case "nome":
                    return query.OrderBy(aluno => aluno.User.UserName);

                case "ra desc":
                    return query.OrderByDescending(aluno => aluno.RA);

                case "ra asc":
                    return query.OrderBy(aluno => aluno.RA);

                default:
                    return query;
            }
        }

        public void Remove(int id)
        {
           var aluno = _contexto.Alunos.Where(x => x.Id == id).FirstOrDefault();
            _contexto.Remove(aluno);
            _contexto.SaveChanges();
        }

        public void Update(Aluno entity)
        {
            _contexto.Alunos.Update(entity);
            _contexto.SaveChanges();
        }

        
    }
}
