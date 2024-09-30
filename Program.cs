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

                var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 2);

                Console.WriteLine(tag?.Name);
            }
        }
    }
}