using LibraryManagementCourse.Data.Model;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementCourse.Data
{
    public class DbInitialize
    {
        public static void Seed(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<LibraryDbContext>();

                // Add Customers
                var justin = new Customer { Name = "Justin Noon" };
                var william = new Customer { Name = "William Parodi" };
                var leoma = new Customer { Name = "Leoma Gosse" };

                context.Customers.Add(justin);
                context.Customers.Add(william);
                context.Customers.Add(leoma);

                // Add Author
                var authorDeMarco = new Author
                {
                    Name = "M J DeMarco",
                    Books = new List<Book>()
                    {
                        new Book { Title = "The Millionaire Fastlane"},
                        new Book { Title = "Unscripted"}
                    }
                };

                var authorCardone = new Author
                {
                    Name = "Grant Cardone",
                    Books = new List<Book>()
                    {
                        new Book { Title = "The 10X Blue"},
                        new Book { Title = "If your are not first, Your are last"},
                        new Book { Title = "Sell to Survive"}
                    }
                };

                context.Authors.Add(authorDeMarco);
                context.Authors.Add(authorCardone);

                context.SaveChanges();
            }

        }
    }
}
