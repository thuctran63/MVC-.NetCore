using FA.JustBlog.Core.Reposiroty;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Views.Shared.Component.LastedPost
{
    public class LastedPostsViewComponent : ViewComponent
    {
        private readonly IPostRepository _postRepository;

        public LastedPostsViewComponent(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IViewComponentResult Invoke()
        {
            var posts = _postRepository.GetLatestPost(5);
            return View(posts);
        }
    }
}
