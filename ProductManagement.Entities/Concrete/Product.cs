using ProductManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Entities.Concrete
{
    public class Product : BaseEntity,IEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
