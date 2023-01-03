using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodAPI.Models
{
    public class CategoryVM
    {
       
       public int Id { get; set; } 
       public string CategoryName { get; set; }

       public string ImageCategory { get; set; }
           public string UserCreated { get; set; }
        
        public DateTime DateCreated { get; set; }
        public virtual ICollection<ProductVM> ProductList { get; set; }

    }
}