using System.Collections.Generic;

namespace Shop.Data.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public ICollection<AutoPartsStore> AutoPartsStores { get; set; } = new List<AutoPartsStore>();

    }
}
