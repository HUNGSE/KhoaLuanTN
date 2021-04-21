using System;
using System.Collections.Generic;
using System.Text;
using IRepositoryBase;
using IServiceBase;
using DataAccess.Models;
using IServices;
using System.Linq.Expressions;

namespace Services
{
    public class ServiceDistricts : IDistrictService
    {
        private readonly IBaseRepository<Districts> _repositoryBase;
        public ServiceDistricts(IBaseRepository<Districts> districts)
        {
            _repositoryBase = districts;
        }
        public void Add(Districts entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(Districts entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<Districts> GetAll()
        {
            return _repositoryBase.GetByWhere(x => true);
        }

        public Districts GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<Districts> GetByWhere(Expression<Func<Districts, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }


        public void Update(Districts entity)
        {
            _repositoryBase.Update(entity);
        }

        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }
    }
}
