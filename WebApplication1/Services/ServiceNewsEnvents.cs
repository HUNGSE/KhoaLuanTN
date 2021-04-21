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
    public class ServiceNewsEnvents : INewsEventService
    {
        private readonly IBaseRepository<NewsEvent> _repositoryBase;
        public ServiceNewsEnvents(IBaseRepository<NewsEvent> newsEvent)
        {
            _repositoryBase = newsEvent;
        }
        public void Add(NewsEvent entity)
        {
            _repositoryBase.Add(entity);
        }

        public void Delete(NewsEvent entity)
        {
            _repositoryBase.Delete(entity);
        }

        public IEnumerable<NewsEvent> GetAll()
        {
            return _repositoryBase.GetByWhere(x => true);
        }

        public NewsEvent GetByID(int id)
        {
            return _repositoryBase.GetByID(id);
        }

        public IEnumerable<NewsEvent> GetByWhere(Expression<Func<NewsEvent, bool>> expression)
        {
            return _repositoryBase.GetByWhere(expression);
        }

        
        public void Update(NewsEvent entity)
        {
            _repositoryBase.Update(entity);
        }
        public int SaveChange()
        {
            return _repositoryBase.Savechange();
        }

    }
}
