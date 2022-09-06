using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T:class
    {
        IEnumerable<T> GetList();
        bool Add(T entity);
        bool Update(T entity);
    }
}
