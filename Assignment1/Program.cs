using Assignment1;
using Core;
using Microsoft.EntityFrameworkCore;

namespace Assignment_EF1
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var context = new DataContext())
            {
                var users = new[]
                {
                    new User { Name = "Kapadia Devanshi", Email = "kapadiad2@mymacewan.ca", Phnnum = 7897546123 },
                new User { Name = "Kesha Sisodia", Email = "keshas@gmail.com", Phnnum = 6497883156 },
                new User { Name = "Mihir Mashilkar", Email = "mihirm@gmail.com", Phnnum = 7893669852 },
            };

            context.Users.AddRange(users);
                context.SaveChanges();


                var posttypes = new[]
            {
                 new PostType { Status = "Active", Name = "Kapadia Devanshi", Description = "My name is Devanshi" },
                new PostType { Status = "InActive", Name = "Kesha Sisodiia", Description = "My name is Kesha" },
            };


                context.PostTypes.AddRange(posttypes);
                context.SaveChanges();



            var blogTypes = new[]
            {
            new BlogType { Status = "Active", Name = "Devanshi Kapadia", Description = "Devanshi's BlogType" },
            new BlogType { Status = "Active", Name = "Kesha Sisodiia", Description = "Kesha's BlogType" },
            };
           
                context.BlogTypes.AddRange(blogTypes);
                context.SaveChanges();

            var blog = new Blog { Url = "https://www.zionadventurephotog.com/", IsPublic = true, BlogTypeId = 1 };

                context.Blogs.Add(blog);
                context.SaveChanges();

                var post = new Post
                {
                    Title = "My First Post",
                    Content = "Hello Everyone, This will be my first Post",
                    BlogId = blog.Id,
                    PostTypeId =posttypes.First().Id,
                    UserId = users.First().Id,
                };

            
            context.Posts.AddRange(post);
            context.SaveChanges();


               
            }

            Console.WriteLine("Hello, World!");

        }
    }
}
