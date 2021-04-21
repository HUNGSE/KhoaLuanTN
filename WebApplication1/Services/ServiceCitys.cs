using DataAccess.Models;
using IServiceBase;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using IRepositoryBase;

namespace Services
{
    public class ServiceCitys : ICityServices
    {
        private readonly IBaseRepository<Citys> _repositoryBase;
        public ServiceCitys(IBaseRepository<Citys> repository)
        {
            _repositoryBase = repository;
        }
        public void Add(Citys entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(Citys entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<Citys> GetAll()
        {
            return _repositoryBase.GetByWhere(x =>true);
        }

        public Citys GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<Citys> GetByWhere(Expression<Func<Citys, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }

        public void Update(Citys entity)
        {
            _repositoryBase.Update(entity);
        }
        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }
    }
}
