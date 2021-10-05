using System;

namespace Catalog2.Dtos
{
      public record Item
    {
        public Guid Id { get; init; }
        public String Name { get; init; }
        public Decimal Price { get; init; }
        public DateTimeOffset Created { get; init; }        
    }
}