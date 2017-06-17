using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleShop.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!context.Items.Any())
            {
                context.AddRange(
                    new Item { Name = "Obraz Ganeshy", Price = 60.00M, ShortDescription = "Piękny obraz", LongDescription = "Oh jaki ten obraz jest piękny, niech państwo spojrzą, to jest arcydzieło! Aż żal nie kupić.", Category = Categories["Art"],  ImageUrl = "https://s-media-cache-ak0.pinimg.com/736x/da/60/87/da608702d8d896097fd64a5691e308e8.jpg", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "http://i.imgur.com/cJQ3U4Z.jpg" },
                    new Item { Name = "TV Panasonic", Price = 400.00M, ShortDescription = "Świtny TV", LongDescription = "Naprawde fajny telewizor.", Category = Categories["Electronics"], ImageUrl = "http://www.komputerswiat.pl/media/2016/84/4335965/004ds600.jpg", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "http://i.imgur.com/ksELYRp.jpg" },
                    new Item { Name = "Myto Ogarów", Price = 30.00M, ShortDescription = "Dobra książka", LongDescription = "Bardzo dobra ksiązka", Category = Categories["Books"], ImageUrl = "http://esensja.pl/obrazki/okladkiks/201058_myto-ogarow_2013_574.jpg", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "http://i.imgur.com/abYvVAw.jpg" } ,
                    new Item { Name = "TestTest", Price = 50.00M, ShortDescription = "TestTestTest", LongDescription = "TestTestTestTestTestTest", Category = Categories["Books"], ImageUrl = "http://chariotlearning.com/wp-content/uploads/2015/12/Testing_in_Progress.gif", InStock = true, IsItemOfTheWeek = true, ImageThumbnailUrl = "http://chariotlearning.com/wp-content/uploads/2015/12/Testing_in_Progress.gif" }

                    );
            }
            context.SaveChanges();
        }

            private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(categories == null)
                {
                    var genresList = new Category[]
                    {
                    new Category {CategoryName = "Electronics"},
                    new Category {CategoryName = "Art"},
                    new Category {CategoryName = "Books"}
                    };

                    categories = new Dictionary<string, Category>();
                    foreach(Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }  
                }
                return categories;
            }
        }        
    }
}
