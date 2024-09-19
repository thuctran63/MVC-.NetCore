using FA.JustBlog.Core.Reposiroty;

namespace FA.JustBlog.Controllers;

public class CategoryController
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    
}