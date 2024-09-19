using FA.JustBlog.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Reposiroty
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly JustBlogContext _context;
        private readonly DbSet<Category> _categories;

        public CategoryRepository(JustBlogContext context)
        {
            _context = context;
            _categories = _context.Categories;
        }

        void ICategoryRepository.AddCategory(Category category)
        {
            _categories.Add(category);
            _context.SaveChanges();
        }

        void ICategoryRepository.DeleteCategory(Category category)
        {
            _categories.Remove(category);
            _context.SaveChanges();
        }

        void ICategoryRepository.DeleteCategory(int categoryId)
        {
            _categories.Remove(_categories.Find(categoryId));
            _context.SaveChanges();
        }

        Category ICategoryRepository.Find(int categoryId)
        {
            return _categories.Find(categoryId);
        }

        IList<Category> ICategoryRepository.GetAllCategories()
        {
            return _categories.ToList();
        }

        void ICategoryRepository.UpdateCategory(Category category)
        {
            _categories.Add(category);
        }
    }
}
