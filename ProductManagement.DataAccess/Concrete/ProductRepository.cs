using ProductManagement.DataAccess.Abstract;
using ProductManagement.DataAccess.Concrete.Contexts;
using ProductManagement.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.DataAccess.Concrete
{
    public class ProductRepository : GenericRepository<Product, AppDbContext>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}
