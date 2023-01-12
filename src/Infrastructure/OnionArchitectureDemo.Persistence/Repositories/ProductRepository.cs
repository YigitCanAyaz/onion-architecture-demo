using Microsoft.EntityFrameworkCore;
using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureDemo.Persistence.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
