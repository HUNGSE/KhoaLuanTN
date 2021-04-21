using System;
using System.Collections.Generic;
using System.Text;
using IServiceBase;
using DataAccess.Models;
using IRepositoryBase;
using System.Linq.Expressions;
using IServices;

namespace Services
{
    public class ServiceCommunes : ICommuneService
    {
        private readonly IBaseRepository<Communes> _repositoryBase;
        public ServiceCommunes(IBaseRepository<Communes> communes)
        {
            _repositoryBase = communes;
        }
        public void Add(Communes entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(Communes entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<Communes> GetAll()
        {
            return _repositoryBase.GetByWhere(x => true);
        }

        public Communes GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<Communes> GetByWhere(Expression<Func<Communes, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }

       
        public void Update(Communes entity)
        {
            _repositoryBase.Update(entity);
        }
        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }

    }
}
