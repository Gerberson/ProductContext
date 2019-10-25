using System;

namespace ProductCatalog.Models
{
    public class Product
    {
        public Product(int id, string title, string description, decimal price, int quantity, string image, DateTime createDate, DateTime lastUpdateDate, int categoryId)
        {
            Id = id;
            Title = title;
            Description = description;
            Price = price;
            Quantity = quantity;
            Image = image;
            CreateDate = createDate;
            LastUpdateDate = lastUpdateDate;
            CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Image { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}