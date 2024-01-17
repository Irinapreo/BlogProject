//SQLite DB Located at: C:\Users\46708\source\repos\BlogProject\EFProject\blogging.db

using EFProject;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;


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

    var displayTree = new DisplayTree();

    Console.WriteLine("User Tree\n");
    displayTree.DisplayUserTree(users);

    Console.WriteLine("\n\nPost Tree:\n");
    displayTree.DisplayPostTree(posts);

    Console.WriteLine("\n\nBlog Tree:\n");
    displayTree.DisplayBlogTree(blogs);
}