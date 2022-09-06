using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiesLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IRepositoryDal<T> _genericRepository;

        public GenericManager(IRepositoryDal<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public bool Add(T entity)
        {
            return _genericRepository.Insert(entity);
        }

        public IEnumerable<T> GetList()
        {
            return _genericRepository.List();
        }

        public bool Update(T entity)
        {
            return _genericRepository.Update(entity);
        }
    }
}
