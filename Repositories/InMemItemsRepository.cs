using System.Collections.Generic;
using Catalog2.Entities;
using System;
using System.Linq;


namespace Catalog2.Repositories
{
    // public interface IItemsRepository
    // {
    //     Item GetItem(Guid id);
    //     IEnumerable<Item> GetItems();
    // }

    public class InMemItemsRepository : IItemsRepository
    {
        private readonly List<Item> items = new()
        {
            new Item { Id = Guid.NewGuid(), Name = "Potion", Price = 8, Created = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Sword", Price = 30, Created = DateTimeOffset.UtcNow },
            new Item { Id = Guid.NewGuid(), Name = "Shield", Price = 18, Created = DateTimeOffset.UtcNow }
        };

        public IEnumerable<Item> GetItems()
        {
            return items;
        }

        public Item GetItem(Guid id)
        {
            return items.Where(item => item.Id == id).SingleOrDefault();
        }
    }
}