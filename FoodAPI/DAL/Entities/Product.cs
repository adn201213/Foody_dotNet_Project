using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.DAL.Entities
{
    public class Product
    {

        [Key]
        public int Id { get; set; }

      
        public string UserCreated { get; set; }
        
        public DateTime DateCreated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }

        public string Type { get; set; }

        public int cuisine { get; set; }
        public int availabilty { get; set; }
  [ForeignKey("CategoryId")]

         public Category Category { get; set; }
       
        public int CategoryId { get; set; }
        
    }
}