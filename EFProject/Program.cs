//SQLite DB Located at: C:\Users\46708\source\repos\BlogProject\EFProject\blogging.db

using EFProject;
using System.Formats.Asn1;
using BloggingContext? db = new();

Console.WriteLine($"SQLite DB Located at: { db.DbPath}");

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