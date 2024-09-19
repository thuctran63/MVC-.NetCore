using FA.JustBlog.Core.Model;
using FA.JustBlog.Core.Reposiroty;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.AuthScheme.PoP;

namespace FA.JustBlog.Controllers
{
    public class PostController : Controller
    {
        public PostController(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        private readonly IPostRepository _postRepository;

        public IActionResult Index()
        {
            var posts = _postRepository.GetAllPosts();
            return View(posts);
        }

        public IActionResult Details(int year, int month, string slug)
        {
            var post = _postRepository.FindPost (year, month, slug);
            return View(post);
        }
        
        [Route("{slug}")]
        public IActionResult Details(string slug)
        {
            var data = _postRepository.GetAllPosts();
            var post = data.Where(p => p.UrlSlug.Equals(slug)).FirstOrDefault();
            return View(post);
        }

        public IActionResult MostViewedPosts()
        {
            var listpost = _postRepository.GetLatestPost(5);
            return View(listpost);
        }



        //[HttpGet("/{category}")]
        //public IActionResult Details(string category)
        //{
        //    var posts = _postRepository.GetPostsByCategory(category);
        //    return View(posts);
        //}
    }
}
