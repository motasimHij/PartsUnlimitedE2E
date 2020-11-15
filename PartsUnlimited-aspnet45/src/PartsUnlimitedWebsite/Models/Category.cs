using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Comments Change Category.cs
namespace PartsUnlimited.Models
{
    public class Category
    {
        //MyThird Change *
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Product> Products { get; set; }
    }
}