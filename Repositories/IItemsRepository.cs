using System.Collections.Generic;
using Catalog2.Entities;
using System;


namespace Catalog2.Repositories
{
        public interface IItemsRepository
    {
        Item GetItem(Guid id);
        IEnumerable<Item> GetItems();
    }
}