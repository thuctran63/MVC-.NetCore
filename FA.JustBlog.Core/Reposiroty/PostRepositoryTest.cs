using FA.JustBlog.Core.Model;

namespace FA.JustBlog.Core.Reposiroty;

public class PostRepositoryTest : IPostRepository
{
    public Post FindPost(int year, int month, string urlSlug)
    {
        return new Post();
    }

    public Post FindPost(int postId)
    {
        return new Post();
    }

    public void AddPost(Post post)
    {
        throw new NotImplementedException();
    }

    public void UpdatePost(Post post)
    {
        throw new NotImplementedException();
    }

    public void DeletePost(Post post)
    {
        throw new NotImplementedException();
    }

    public void DeletePost(int postId)
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetAllPosts()
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetPublisedPosts()
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetUnpublisedPosts()
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetLatestPost(int size)
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetPostsByMonth(DateTime monthYear)
    {
        throw new NotImplementedException();
    }

    public int CountPostsForCategory(string category)
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetPostsByCategory(string category)
    {
        throw new NotImplementedException();
    }

    public int CountPostsForTag(string tag)
    {
        throw new NotImplementedException();
    }

    public IList<Post> GetPostsByTag(string tag)
    {
        throw new NotImplementedException();
    }
}