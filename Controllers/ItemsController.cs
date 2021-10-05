using Microsoft.AspNetCore.Mvc;
using Catalog2.Repositories;
using System.Collections.Generic;
using Catalog2.Entities;
using System;
using System.Net.Http;
using System.Text;

namespace Catalog2.Controllers
{    
    // adds defualt behaviour that helps
    [ApiController]
    [Route("items")]
    public class ItemsController : ControllerBase
    {
        private readonly IItemsRepository repository;

        public ItemsController(IItemsRepository repository)
        {
            // repository = new InMemItemsRepository();
            this.repository = repository;
        }

        [HttpGet]
        public IEnumerable<Item> GetItems()
        {
            var items = repository.GetItems();
            return items;
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id)
        {
            var item = repository.GetItem(id);

            if (item == null) 
            {
                return NotFound();
            }
            return item;
        }
    }
}