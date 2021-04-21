using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Models;
using IRepositoryBase;
using IServiceBase;
using IServices;

namespace Services
{
    public class ServiceProjectTypes : IProjectTypeService
    {
        private readonly IBaseRepository<ProjectTypes> _repositoryBase;
        public ServiceProjectTypes(IBaseRepository<ProjectTypes> projectTypes)
        {
            _repositoryBase = projectTypes;
        }
        public void Add(ProjectTypes entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(ProjectTypes entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<ProjectTypes> GetAll()
        {
            return _repositoryBase.GetByWhere(x => true);
        }

        public ProjectTypes GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<ProjectTypes> GetByWhere(Expression<Func<ProjectTypes, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }


        public void Update(ProjectTypes entity)
        {
            _repositoryBase.Update(entity);
        }

        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }
    }
}
