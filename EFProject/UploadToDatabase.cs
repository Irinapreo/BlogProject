
namespace EFProject;

public class UploadToDatabase
{
    public void UploadUserData(List<User> users, BloggingContext dbContext)
    {
        foreach (var user in users)
        {
            if (!dbContext.Users.Any(u => u.UserId == user.UserId))
            {
                dbContext.Users.Add(user);
            }
            else
            {
                Console.WriteLine($"User with ID {user.UserId} already exists. Skipping duplicate entry.");
            }
        }

        dbContext.SaveChanges();
    }

    public void UploadUBlogData(List<Blog> blogs, BloggingContext dbContext)
    {
        foreach (var blog in blogs)
        {
            if (!dbContext.Blogs.Any(b => b.BlogId == blog.BlogId))
            {
                dbContext.Blogs.Add(blog);
            }
            else
            {
                Console.WriteLine($"Blog with ID {blog.BlogId} already exists. Skipping duplicate entry.");
            }
        }
    }

    public void UploadUPostData(List<Post> posts, BloggingContext dbContext)
    {
        foreach (var post in posts)
        {
            if (!dbContext.Posts.Any(p => p.PostId == post.PostId))
            {
                dbContext.Posts.Add(post);
            }
            else
            {
                Console.WriteLine($"Post with ID {post.PostId} already exists. Skipping duplicate entry.");
            }
        }

        dbContext.SaveChanges();
    }
}
