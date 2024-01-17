
namespace EFProject;

public class ReadAndConvertCsvToList
{
    public List<User> UserCsv()
    {
        var users = new List<User>();
        var lines = File.ReadAllLines("../User.csv");

        foreach (var line in lines)
        {
            var values = line.Split(',');

            if (values.Length == 4 && int.TryParse(values[0], out int id) && int.TryParse(values[3], out int postId))
            {
                var user = new User
                {
                    UserId = id,
                    Username = values[1],
                    Password = values[2],
                    PostId = postId
                };
                users.Add(user);
            }
            else
            {
                Console.WriteLine($"Invalid CSV data in file {"../User.csv"}: {line}");
            }
        }
        return users;
    }

    public List<Post> PostCsv()
    {
        var posts = new List<Post>();

        var lines = File.ReadAllLines("../Post.csv");

        foreach (var line in lines)
        {
            var values = line.Split(',');
            if (values.Length == 5 
                && int.TryParse(values[0], out int id) 
                && int.TryParse(values[3], out int blogId) 
                && int.TryParse(values[4], out int userId))
            {
                var post = new Post
                {
                    PostId = id,
                    Title = values[1],
                    Content = values[2],
                    BlogId = blogId,
                    UserId = userId
                };

                posts.Add(post);
            }
            else
            {
                Console.WriteLine($"Invalid CSV data in file {"../Post.csv"}: {line}");
            }
        }

        return posts;
    }

    public List<Blog> BlogCsv()
    {
        var blogs = new List<Blog>();

        var lines = File.ReadAllLines("../Blog.csv");

        foreach (var line in lines)
        {
            var values = line.Split(',');

            if (values.Length == 4 &&
                int.TryParse(values[0], out int id) &&
                int.TryParse(values[3], out int postId))
            {
                var blog = new Blog
                {
                    BlogId = id,
                    Url = values[1],
                    Name = values[2],
                    PostId = postId
                };

                blogs.Add(blog);
            }
            else
            {
                Console.WriteLine($"Invalid CSV data in file {"../Blog.csv"}: {line}");
            }
        }
        return blogs;
    }

}
