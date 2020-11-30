using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using ShoppingCart.Domain.Models;

namespace ShoppingCart.Domain.Interfaces
{
    public interface ICategoriesRepository
    {

        IQueryable<Category> GetCategories();
        Category Category(int id);

        void AddCategory(Category c);

        void DeleteCategory(int id);
    }
}
