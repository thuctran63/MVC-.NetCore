using FA.JustBlog.Core.Reposiroty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace FA.JustBlog.Views.Shared.Components.ListCategory;

public class ListCategoryViewComponent : ViewComponent
{
    private readonly ICategoryRepository _categoryRepository;

    public ListCategoryViewComponent(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IViewComponentResult Invoke()
    {
        var allCategories = _categoryRepository.GetAllCategories();
        return View(allCategories);
    }
    
}