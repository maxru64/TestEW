using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class AutoPartsStore
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
