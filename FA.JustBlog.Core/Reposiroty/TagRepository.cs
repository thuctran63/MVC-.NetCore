using FA.JustBlog.Core.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Reposiroty
{
    public class TagRepository : ITagRepository
    {
        private readonly JustBlogContext _context;
        private readonly DbSet<Tag> _tags;

        public TagRepository(JustBlogContext context)
        {
            _context = context;
            _tags = _context.Tags;
        }


        void ITagRepository.AddTag(Tag Tag)
        {
            _tags.Add(Tag);
            _context.SaveChanges();
        }

        void ITagRepository.DeleteTag(Tag Tag)
        {
            _tags.Remove(Tag);
            _context.SaveChanges();
        }

        void ITagRepository.DeleteTag(int TagId)
        {
            _tags.Remove(_tags.Find(TagId));
            _context.SaveChanges();
        }

        Tag ITagRepository.Find(int TagId)
        {
            return _tags.Find(TagId);
        }

        IList<Tag> ITagRepository.GetAllTags()
        {
            return _tags.ToList();
        }

        Tag ITagRepository.GetTagByUrlSlug(string urlSlug)
        {
            return _tags.FirstOrDefault(t => t.UrlSlug == urlSlug);
        }

        void ITagRepository.UpdateTag(Tag Tag)
        {
            _tags.Add(Tag);
        }
    }
}
