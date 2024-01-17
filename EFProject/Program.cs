//SQLite DB Located at: C:\Users\46708\source\repos\BlogProject\EFProject\blogging.db

using EFProject;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using BloggingContext? db = new();

Console.WriteLine($"SQLite DB Located at: {db.DbPath}");

ReadAndConvertCsv csvReader = new ReadAndConvertCsv();

// Call the UserCsv method
List<Post> posts = csvReader.PostCsv();

// Now you can work with the 'users' list in your program
foreach (var post in posts)
{
    Console.WriteLine($"Post ID: {post.PostId}, " +
        $"Title: {post.Title}, " +
        $"Content: {post.Content}, " +
        $"BlogId: {post.BlogId}, " +
        $"User Id: {post.UserId}");
}


void Program()
{
    string userCsvPath = "../../../User.csv";
    string postCsvPath = "../../../Post.csv";
    string blogCsvPath = "../../../Blog.csv";
    var csvReader = new ReadAndConvertCsvToList();

    using (var dbContext = new BloggingContext())
    {
        var users = csvReader.UserCsv();
        var posts = csvReader.PostCsv();
        var blogs = csvReader.BlogCsv();

        var databaseUploader = new UploadToDatabase();

        databaseUploader.UploadUserData(users, dbContext);
        databaseUploader.UploadUPostData(posts, dbContext);
        databaseUploader.UploadUBlogData(blogs, dbContext);

        //Console.WriteLine("User Tree:");
        //DisplayUserTree(users);
        //DisplayUserTree(posts);
        //DisplayUserTree(blogs);

    }
}
