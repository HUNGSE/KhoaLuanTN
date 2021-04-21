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
    public class ServiceRealEstateTypes : IRealEstateTypeService
    {
        private readonly IBaseRepository<RealEstateTypes> _repositoryBase;
        public ServiceRealEstateTypes(IBaseRepository<RealEstateTypes> realEstateTypes)
        {
            _repositoryBase = realEstateTypes;
        }
        public void Add(RealEstateTypes entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(RealEstateTypes entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<RealEstateTypes> GetAll()
        {
            return _repositoryBase.GetByWhere(x => true);
        }

        public RealEstateTypes GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<RealEstateTypes> GetByWhere(Expression<Func<RealEstateTypes, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }
        public void Update(RealEstateTypes entity)
        {
            _repositoryBase.Update(entity);
        }
        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }

        
    }
}
