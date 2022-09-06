using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using EntitiesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class ProductRepository : GenericRepository<Product>,IProductDal
    {
        private readonly ProjeContext _context;

        public ProductRepository(ProjeContext context) : base(context)
        {
            _context = context;
        }
    }
}


