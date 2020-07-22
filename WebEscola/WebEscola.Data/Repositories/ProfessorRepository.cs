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
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly EscolaContexto _contexto;

        public ProfessorRepository(EscolaContexto contexto)
        {
            _contexto = contexto;
        }
        public int Add(Professor entity)
        {
            _contexto.Professores.Add(entity);
            _contexto.SaveChanges();
            return entity.Id;
        }

        public Professor FindById(int id)
        {
            return _contexto.Professores.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Professor> GetAll()
        {
            return _contexto.Professores.ToList();
        }

        Page<Professor> IProfessorRepository.GetPage(PageFilter pageFilter, string sortingProperty)
        {

            IQueryable<Professor> query = _contexto.Professores;

            return OrdenarProfessores(query, sortingProperty).ToPage(pageFilter);
        }

        private IQueryable<Professor> OrdenarProfessores(IQueryable<Professor> query, string sortingProperty)
        {
            switch (sortingProperty.ToLower().Trim())
            {
                case "nome":
                    return query.OrderBy(professor => professor.User.UserName);

                case "codigfunc desc":
                    return query.OrderByDescending(professor => professor.CodigoFuncionario);

                case "codigfunc asc":
                    return query.OrderBy(professor => professor.CodigoFuncionario);

                default:
                    return query;
            }
        }

        public void Remove(int id)
        {
           var professor = _contexto.Professores.Where(x => x.Id == id).FirstOrDefault();
            _contexto.Remove(professor);
            _contexto.SaveChanges();
        }

        public void Update(Professor entity)
        {
            _contexto.Professores.Update(entity);
            _contexto.SaveChanges();
        }
       
    }
}
