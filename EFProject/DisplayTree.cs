
namespace EFProject;

public class DisplayTree
{
    public void DisplayUserTree(List<User> users)
    {
        foreach (var user in users)
        {
            Console.WriteLine($"User Id: {user.UserId}, " +
                $"Username: {user.Username}, " +
                $"Password: {user.Password}, " +
                $"Post Id: {user.PostId}");
        }
    }

    public void DisplayPostTree(List<Post> posts)
    {
        foreach (var post in posts)
        {
            Console.WriteLine($"Post ID: {post.PostId}, " +
                $"Title: {post.Title}, " +
                $"Content: {post.Content}, " +
                $"Blog Id: {post.BlogId}, " +
                $"User Id: {post.UserId}");
        }
    }
    public void DisplayBlogTree(List<Blog> blogs)
    {
        foreach (var blog in blogs)
        {
            Console.WriteLine($"Blog Id: {blog.BlogId}, " +
                $"Url: {blog.Url}, " +
                $"Name: {blog.Name}, " +
                $"Post Id: {blog.PostId}");
        }
    }
}
