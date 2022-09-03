using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.DAL.Entities
{
    public class Category
    {
        [Key]
       public int Id { get; set; } 
       public string CategoryName { get; set; }

       public string ImageCategory { get; set; }
           public string UserCreated { get; set; }
        
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Product> ProductList { get; set; }

    }
}