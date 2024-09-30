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
                //var tag = new Tag { Name = "ASP.NET",
                //Slug= "asp.net"};

                //context.Tags.Add(tag);
                //context.SaveChanges();

                var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                tag.Name = ".Net";
                tag.Slug = "dotnet";

                context.Update(tag);
                context.SaveChanges();

            }
        }
    }
}