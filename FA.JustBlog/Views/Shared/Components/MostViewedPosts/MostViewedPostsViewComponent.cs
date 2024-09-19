using FA.JustBlog.Core.Reposiroty;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Views.Shared.Components.MostViewedPosts
{
    public class MostViewedPostsViewComponent : ViewComponent
    {
        private readonly IPostRepository postRepository;

        public MostViewedPostsViewComponent(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public IViewComponentResult Invoke()
        {
            var data = postRepository.GetLatestPost(5);
            return View(data);
        }
    }
}
