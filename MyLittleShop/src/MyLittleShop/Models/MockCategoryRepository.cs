using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryId = 1, CategoryName = "Electronics", Description = "Czysta elektronika" },
                    new Category { CategoryId = 2, CategoryName = "Art", Description = "Co nieco ze sztuki" },
                    new Category { CategoryId = 3, CategoryName = "Books", Description = "Książki" },

                };
            }
        }
    }
}
