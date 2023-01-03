using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.BL.Interface;
using FoodAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FoodAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
  private readonly IProduct _ProductRepo;
        public ProductController(IProduct ProductRepo)
        {
          _ProductRepo=ProductRepo;  
        }
[HttpGet]
        public IEnumerable<ProductVM> Get(){

return _ProductRepo.GetAll();

        }

       [HttpGet("{id}")]
        public ProductVM Get(int id){

return _ProductRepo.get(id);

        } 

              [HttpPost()]
        public ProductVM Post(ProductVM productVM){

return _ProductRepo.Add(productVM);

        }  

    [HttpPut()]
        public ProductVM Put(ProductVM productVM){

return _ProductRepo.Edit(productVM);

        }  
          [HttpDelete()]
        public ProductVM Delete(ProductVM productVM){

return _ProductRepo.Delete(productVM);

        }  
    }
}