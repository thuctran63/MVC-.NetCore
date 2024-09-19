using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Model
{
    public class JustBlogContext : DbContext
    {
        private readonly string? _connectionString;

        public JustBlogContext() : base()
        {

        }

        public JustBlogContext(DbContextOptions<JustBlogContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().HasOne(p => p.Category).WithMany(c => c.Posts).HasForeignKey(p => p.CategoryId);
            modelBuilder.Entity<Post>().HasMany(p => p.Tags).WithMany(t => t.Posts);

            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = "1",
                    Name = "Programming",
                    UrlSlug = "programming",
                    Description = "Programming Language",
                },
                new Category
                {
                    Id = "2",
                    Name = "Technology",
                    UrlSlug = "technology",
                    Description = "Technology News",
                },
                new Category
                {
                    Id = "3",
                    Name = "Life",
                    UrlSlug = "life",
                    Description = "Life Style",
                }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag
                {
                    Id = "1",
                    Name = "C#",
                    UrlSlug = "csharp",
                    Description = "C# Programming Language",
                    Count = 0
                },
                new Tag
                {
                    Id = "2",
                    Name = "ASP.NET",
                    UrlSlug = "aspnet",
                    Description = "ASP.NET Web Development",
                    Count = 0
                },
                new Tag
                {
                    Id = "3",
                    Name = "SQL Server",
                    UrlSlug = "sqlserver",
                    Description = "SQL Server Database",
                    Count = 0
                }
            );


            modelBuilder.Entity<Post>().HasData(
                new Post
                {
                    Id = "1",
                    Title = "Post 1",
                    ShortDescription = "Post 1 Short Description",
                    UrlSlug = "post-1",
                    Published = true,
                    PostedOn = DateTime.Now.Date,
                    Modified = DateTime.Now.Date,
                    CategoryId = "1",
                    PostContent = "Post 1 Content AABBCC"
                },

                new Post
                {
                    Id = "2",
                    Title = "Post 2",
                    ShortDescription = "Post 2 Short Description",
                    UrlSlug = "post-2",
                    Published = true,
                    PostedOn = DateTime.Now.Date,
                    Modified = DateTime.Now.Date,
                    CategoryId = "2",
                    PostContent = "Post 2 Content AABBCC"
                }
                );

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-OQH9VEI;Initial Catalog=JustBlog;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }


    }
}
