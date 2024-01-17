
namespace EFProject;

public class UploadToDatabase
{
    public void UploadUserData(List<User> users, BloggingContext dbContext)
    {
        dbContext.Users.AddRange(users);
        dbContext.SaveChanges();
    }

    public void UploadUBlogData(List<Blog> blogs, BloggingContext dbContext)
    {
        dbContext.Blogs.AddRange(blogs);
        dbContext.SaveChanges();
    }

    public void UploadUPostData(List<Post> posts, BloggingContext dbContext)
    {
        dbContext.Posts.AddRange(posts);
        dbContext.SaveChanges();
    }
}
