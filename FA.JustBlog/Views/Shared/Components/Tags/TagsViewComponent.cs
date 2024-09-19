using FA.JustBlog.Core.Reposiroty;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Views.Shared.Components.Tags
{
    public class TagsViewComponent : ViewComponent
    {
        private readonly ITagRepository _tagRepository;

        public TagsViewComponent(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public IViewComponentResult Invoke()
        {
            var tags = _tagRepository.GetAllTags();
            return View(tags);
        }
    }
}
