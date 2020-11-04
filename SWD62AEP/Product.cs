using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;


namespace.ShoppingCart.Domain.Models
{
    public Product()
    {


        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public Category Category {get; set; }
    
}
}
