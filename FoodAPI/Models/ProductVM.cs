using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Models
{
    public class ProductVM
    {

       
        public int Id { get; set; }
        public string? UserCreated { get; set; }
        public DateTime DateCreated { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Type { get; set; }

        public string? cuisine { get; set; }
        public int availabilty { get; set; }
 

         public Category Category { get; set; }
       
        public int CategoryId { get; set; }
        
    }
}