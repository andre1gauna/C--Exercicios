using Escola.Data.Context;
using Escola.Domain.Models;
using System.Collections.Generic;
using System.Linq;
using WebEscola.Data.Extensions;
using WebEscola.Domain.Interfaces;
using WebEscola.Domain.Models;

namespace WebEscola.Data.Repositories
{
    public class GradeRepository : IGradeRepository
    {
        private readonly EscolaContexto _contexto;
        public GradeRepository(EscolaContexto context)
        {
            _contexto = context;
        }

        public int Add(Grade entity)
        {
            _contexto.Grades.Add(entity);
            _contexto.SaveChanges();
            return entity.Id;
        }

        public Grade FindById(int id)
        {
            return _contexto.Grades.Where(i => i.Id == id).FirstOrDefault();
        }

        public IEnumerable<Grade> GetAll()
        {
            return _contexto.Grades.ToList();
        }

        public Page<Grade> GetPage(PageFilter pageFilter, string sortingProperty)
        {

            IQueryable<Grade> query = _contexto.Grades;

            return OrdenarGrades(query, sortingProperty).ToPage(pageFilter);
        }

        private IQueryable<Grade> OrdenarGrades(IQueryable<Grade> query, string sortingProperty)
        {
            switch (sortingProperty.ToLower().Trim())
            {
                case "nomecurso":
                    return query.OrderBy(grade => grade.NomeCurso);

                case "nomedisciplina":
                    return query.OrderBy(grade => grade.NomeDisciplina);

                case "nometurma":
                    return query.OrderBy(grade => grade.NomeTurma);                

                default:
                    return query;
            }
        }

        public void Remove(int id)
        {
            var grade = _contexto.Grades.First(x => x.Id == id);
            _contexto.Grades.Remove(grade);
            _contexto.SaveChanges();
        }

        public void Update(Grade entity)
        {
            _contexto.Grades.Update(entity);
            _contexto.SaveChanges();
        }
    }
}