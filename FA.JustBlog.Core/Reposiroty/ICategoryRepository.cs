using FA.JustBlog.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Reposiroty
{
    public interface ICategoryRepository
    {
        Category Find(int categoryId);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void DeleteCategory(int categoryId);
        IList<Category> GetAllCategories();
    }
}
