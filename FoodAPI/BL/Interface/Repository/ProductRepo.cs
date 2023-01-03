using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.DAL.DataBase;
using FoodAPI.DAL.Entities;
using FoodAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.BL.Interface.Repository
{


  public class ProductRepo : IProduct
  {

     private readonly DbContainer _db;
    public ProductRepo(DbContainer db)
    {
      _db = db;
        
    }
    public ProductVM Add(ProductVM productVM)
    {
      
    Product product=new Product{
         Id =productVM.Id,
         UserCreated=productVM.UserCreated,
         DateCreated=productVM.DateCreated, 
         Name =productVM.Name,
         Description=productVM.Description, 
         Price=productVM.Price, 
        ImageUrl=productVM.ImageUrl, 
        TypeFood=productVM.Type, 
         cuisine =productVM.cuisine,
         availabilty=productVM.availabilty, 
         Category= productVM.Category,
       CategoryId=productVM.CategoryId

    };
    
    _db.Add(product);
    _db.SaveChanges();
    return productVM;
    }

    public ProductVM Delete(ProductVM productVM)
    {
      Product product=_db.Products.Find(productVM.Id);
     

                 _db.Remove(product);
                    _db.SaveChanges();
                 return productVM;
    }

    public ProductVM Edit(ProductVM productVM)
    {
  Product product=_db.Products.Find(productVM.Id);
    
         product.Id =productVM.Id;
        product.UserCreated=productVM.UserCreated;
         product.DateCreated=productVM.DateCreated; 
         product.Name =productVM.Name;
        product.Description=productVM.Description; 
        product.Price=productVM.Price; 
        product.ImageUrl=productVM.ImageUrl; 
        product.TypeFood=productVM.Type; 
         product.cuisine =productVM.cuisine;
         product.availabilty=productVM.availabilty; 
         product.Category= productVM.Category;
       product.CategoryId=productVM.CategoryId;

    _db.Entry(product).State=EntityState.Modified;

     _db.SaveChanges();
     return productVM;
    }

    public ProductVM get(int id)
    {
       var product= _db.Products.Select( a=>new ProductVM{
         Id =a.Id,
         UserCreated=a.UserCreated,
         DateCreated=a.DateCreated, 
         Name =a.Name,
         Description=a.Description, 
         Price=a.Price, 
        ImageUrl=a.ImageUrl, 
        Type=a.TypeFood, 
         cuisine =a.cuisine,
         availabilty=a.availabilty, 
         Category= a.Category,
       CategoryId=a.CategoryId

    }).Where(a=>a.Id==id).SingleOrDefault();
    return product;
    }
    public IQueryable<ProductVM> GetAll()
    {
        var products=  _db.Products.Select(
            a=>new ProductVM{
                   Id =a.Id,
         UserCreated=a.UserCreated,
         DateCreated=a.DateCreated, 
         Name =a.Name,
         Description=a.Description, 
         Price=a.Price, 
         ImageUrl=a.ImageUrl, 
         Type=a.TypeFood, 
         cuisine =a.cuisine,
         availabilty=a.availabilty, 
         Category= a.Category,
         CategoryId=a.CategoryId
            }
        );
     
     return products;
      
    }

//  public  IQueryable<Product> GetAll(){


//  IQueryable<Product> products = _db.Products.AsQueryable();
//  return products;
//  }

//     IQueryable<ProductVM> GetAll()
//     {
//     IQueryable<Product> products = _db.Products.AsQueryable();
//  return products;
//     }



  }





}