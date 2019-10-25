using System.Collections.Generic;

namespace ProductCatalog.Models
{
    public class Category
    {
        public Category(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}