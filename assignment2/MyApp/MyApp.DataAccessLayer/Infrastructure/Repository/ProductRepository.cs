using MyApp.Models;
using MyApp.DataAccessLayer.Infrastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyApp.DataAccessLayer.Data;

namespace MyApp.DataAccessLayer.Infrastructure.Repository
{
    public class ProductRepository : Reposistory<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(Product product)
        {
            var productDb = _context.Products.FirstOrDefault(x=>x.Id==product.Id);
            if(productDb!=null)
            {
                productDb.Name = product.Name;
                productDb.Price = product.Price;
                productDb.Description = product.Description;
                if(product.ImageUrl!=null)
                {
                    productDb.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
