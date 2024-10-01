using System;
using System.Linq;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BlogDataContext())
            {
                #region Modulo 1
                //var tag = new Tag
                //{
                //    Name = ".Net",
                //Slug = "dotnet"
                //};

                //var tag2 = new Tag
                //{
                //    Name = "ASP.NET",
                //    Slug = "asp.net"
                //};

                //context.Tags.Add(tag);
                //context.Tags.Add(tag2);
                //context.SaveChanges();

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //tag.Name = ".Net";
                //tag.Slug = "dotnet";

                //context.Update(tag);
                //context.SaveChanges();

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                //context.Remove(tag);
                //context.SaveChanges();

                //var tags = context.Tags
                //    .AsNoTracking()
                //    .ToList();

                //foreach (var item in tags)
                //{
                //    Console.WriteLine(item.Name);
                //}

                //var tag = context.Tags.FirstOrDefault(x => x.Id == 2);
                //tag.Name = ".Net";
                //tag.Slug = "dotnet";

                //context.Update(tag);
                //context.SaveChanges();

                //var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);

                //Console.WriteLine(tag?.Name);

                #endregion

                #region Modulo 2

                //var user = new User
                //{
                //    Name = "André Baltieri",
                //    Slug = "andrebaltieri",
                //    Email = "andre@balta.io",
                //    Bio = "9x Microsoft MVP",
                //    Image = "https://balta.io",
                //    PasswordHash = "123098457"
                //};

                //var category = new Category { Name = "Backend", Slug = "backend" };

                //var post = new Post
                //{
                //    Author = user,
                //    Category = category,
                //    Body = "<p>Hello world</p>",
                //    Slug = "comecando-com-ef-core",
                //    Summary = "Neste artigo vamos aprender EF core",
                //    Title = "Começando com EF Core",
                //    CreateDate = DateTime.Now,
                //    LastUpdateDate = DateTime.Now,
                //};

                //context.Posts.Add(post); // Não adicionei autor nem categoria
                //context.SaveChanges();

                //var posts = context
                //    .Posts
                //    .AsNoTracking()
                //    .Include(x => x.Author)
                //    .Include(x => x.Category)
                //    .OrderBy(x => x.LastUpdateDate)
                //    .ToList();

                // foreach (var post in posts) 
                //     Console.WriteLine($"{post.Title} por {post.Author.Name} em {post.Category.Name}");

                // var post = context
                //     .Posts
                //     // .AsNoTracking() PRECISA DO TRACKING 
                //     .Include(x => x.Author)
                //     .Include(x => x.Category)
                //     .OrderBy(x => x.LastUpdateDate)
                //     .FirstOrDefault(); // Pegando o primeiro item
                //
                // post.Author.Name = "Uncle Bob";
                //
                // context.Posts.Update(post);
                // context.SaveChanges();

                #endregion
            }
        }
    }
}