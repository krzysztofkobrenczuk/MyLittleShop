using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleShop.Models
{
    public class MockItemRepository  : IItemRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Item> Items
        {
            get
            {
                return new List<Item>
                {
                    new Item {ItemId = 1, Name="Obraz Ganeshy", Price=60.00M, ShortDescription="Piękny obraz", LongDescription="Oh jaki ten obraz jest piękny, niech państwo spojrzą, to jest arcydzieło! Aż żal nie kupić.", Category = _categoryRepository.Categories.ToList()[1],ImageUrl="https://s-media-cache-ak0.pinimg.com/736x/da/60/87/da608702d8d896097fd64a5691e308e8.jpg", InStock=true, IsItemOfTheWeek=false, ImageThumbnailUrl="http://i.imgur.com/cJQ3U4Z.jpg"},
                    new Item {ItemId = 2, Name="TV Panasonic", Price=400.00M, ShortDescription="Świtny TV", LongDescription="Oh jaki ten monitor jest piękny, niech państwo spojrzą, to jest arcydzieło! Aż żal nie kupić.", Category = _categoryRepository.Categories.ToList()[0],ImageUrl="https://images.morele.net/full/634843_1_f.jpg", InStock=true, IsItemOfTheWeek=false, ImageThumbnailUrl="http://i.imgur.com/ksELYRp.jpg"},
                    new Item {ItemId = 3, Name="Myto Ogarów", Price=30.00M, ShortDescription="Dobra książka", LongDescription="Oh jaki ten mask jest piękny i to z AFRYKI. AFRYKI! Niech państwo spojrzą, to jest arcydzieło! Aż żal nie kupić.", Category = _categoryRepository.Categories.ToList()[2],ImageUrl="https://image.ceneo.pl/data/products/26597197/i-maska-psy-gangnam-style.jpg", InStock=true, IsItemOfTheWeek=false, ImageThumbnailUrl="http://i.imgur.com/abYvVAw.jpg"},

                };
            }
        }
        public IEnumerable<Item> ItemOfTheWeek { get; }
        public Item GetItemById(int itemId)
        {
            throw new System.NotImplementedException();
        }

    }
}
