
using EFProject;
using BloggingContext? db = new();

Console.WriteLine($"SQLite DB Located at: { db.DbPath}");
