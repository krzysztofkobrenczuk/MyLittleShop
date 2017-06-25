using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyLittleShop.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Item> Items
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }
        public IEnumerable<Item> ItemOfTheWeek
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(p => p.IsItemOfTheWeek);
            }
        }
        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(p => p.ItemId == itemId);
        }
    }
}
