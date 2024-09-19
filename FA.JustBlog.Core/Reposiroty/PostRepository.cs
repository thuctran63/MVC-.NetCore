using FA.JustBlog.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Reposiroty
{
    public class PostRepository : IPostRepository
    {
        private readonly JustBlogContext _context;

        public PostRepository(JustBlogContext context)
        {
            _context = context;
        }

        void IPostRepository.AddPost(Post post)
        {
            _context.Posts.Add(post);
            _context.SaveChanges();
        }

        int IPostRepository.CountPostsForCategory(string category)
        {
            return _context.Posts.Count(p => p.Category.Name == category);
        }

        int IPostRepository.CountPostsForTag(string tag)
        {
            return _context.Posts.Count(p => p.Tags.Any(t => t.Name == tag));
        }

        void IPostRepository.DeletePost(Post post)
        {
            _context.Posts.Remove(post);
            _context.SaveChanges();
        }

        void IPostRepository.DeletePost(int postId)
        {
            _context?.Remove(_context.Posts.Find(postId));
            _context?.SaveChanges();
        }

        Post IPostRepository.FindPost(int year, int month, string urlSlug)
        {
            var post = _context.Posts.FirstOrDefault(p => p.UrlSlug == urlSlug && p.PostedOn.Year == year && p.PostedOn.Month == month);
            return post;
        }

        Post IPostRepository.FindPost(int postId)
        {
            return _context.Posts.Find(postId);
        }

        IList<Post> IPostRepository.GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        IList<Post> IPostRepository.GetLatestPost(int size)
        {
            return _context.Posts.OrderByDescending(p => p.PostedOn).Take(size).ToList();
        }

        IList<Post> IPostRepository.GetPostsByCategory(string category)
        {
            return _context.Posts.Where(p => p.Category.Name == category).ToList();
        }

        IList<Post> IPostRepository.GetPostsByMonth(DateTime monthYear)
        {
            return _context.Posts.Where(p => p.PostedOn.Month == monthYear.Month && p.PostedOn.Year == monthYear.Year).ToList();
        }

        IList<Post> IPostRepository.GetPostsByTag(string tag) 
        {
            return _context.Posts.Where(p => p.Tags.Any(t => t.Name == tag)).ToList();
        }

        IList<Post> IPostRepository.GetPublisedPosts()
        {
            return _context.Posts.Where(p => p.Published == true).ToList();
        }

        IList<Post> IPostRepository.GetUnpublisedPosts()
        {
            return _context.Posts.Where(p => p.Published == false).ToList();
        }

        void IPostRepository.UpdatePost(Post post)
        {
            _context.Posts.Update(post);
            _context.SaveChanges();
        }
    }
}
