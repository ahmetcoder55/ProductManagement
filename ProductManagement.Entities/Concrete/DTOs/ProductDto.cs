using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Entities.Concrete.DTOs
{
    public record ProductDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public decimal Price { get; init; }
        public int Stock { get; init; }
        public DateTime CreatedDate { get; init; }
    }
}
