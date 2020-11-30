using ShoppingCart.Data.Context;
using ShoppingCart.Domain.Interfaces;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Data.Repositories
{
    public class CategoriesRepository:ICategoriesRepository
    {

        private ShoppingCartDbContext _context;
        public CategoriesRepository(ShoppingCartDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category c)
        {
            throw new NotImplementedException();
        }

        public Category Category(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Category> GetCategories()
        {
            return _context.Categories;
        }
    }
}
