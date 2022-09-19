using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.Models;

namespace FoodAPI.BL.Interface
{
    public interface IProduct
    {
  IQueryable<ProductVM> GetAll();
  ProductVM get(int id);
  ProductVM Add(ProductVM product);
  ProductVM Edit(ProductVM product);
  ProductVM Delete(ProductVM product);

    }
}