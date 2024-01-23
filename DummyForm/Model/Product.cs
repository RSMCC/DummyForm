using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyForm.Modelo
{
    public class Product
    {
        [JsonProperty("id")]
        int id;
        [JsonProperty("title")]
        string title;
        [JsonProperty("description")]
        string description;
        [JsonProperty("price")]
        int price;
        [JsonProperty("discountPercentage")]
        double discountPercentage;
        [JsonProperty("rating")]
        double rating;
        [JsonProperty("stock")]
        int stock;
        [JsonProperty("brand")]
        string brand;
        [JsonProperty("category")]
        string category;
        [JsonProperty("thumbnail")]
        string thumbnail;
        [JsonProperty("images")]
        string[] images;

        public Product()
        {
            this.Id = 0;
            this.Title = "";
            this.Description = "";
            this.Price = 0;
            this.DiscountPercentage = 0;
            this.Rating = 0;
            this.Stock = 0;
            this.Brand = "";
            this.Category = "";
            this.Thumbnail = "";
            this.Images = [];
        }

        public Product(int id, string title, string description, int price, double discountPercentage, double rating, int stock, string brand, string category, string thumbnail)
        {
            this.Id = id;
            this.Title = title ?? throw new ArgumentNullException(nameof(title));
            this.Description = description ?? throw new ArgumentNullException(nameof(description));
            this.Price = price;
            this.DiscountPercentage = discountPercentage;
            this.Rating = rating;
            this.Stock = stock;
            this.Brand = brand ?? throw new ArgumentNullException(nameof(brand));
            this.Category = category ?? throw new ArgumentNullException(nameof(category));
            this.Thumbnail = thumbnail ?? throw new ArgumentNullException(nameof(thumbnail));
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public double DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }
        public double Rating { get => rating; set => rating = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Category { get => category; set => category = value; }
        public string Thumbnail { get => thumbnail; set => thumbnail = value; }
        public string[] Images { get => images; set => images = value; }
    }
}
