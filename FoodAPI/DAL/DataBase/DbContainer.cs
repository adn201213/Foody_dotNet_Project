using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace FoodAPI.DAL.DataBase
{
    public class DbContainer:DbContext
    {
    

 public DbContainer(DbContextOptions<DbContainer> options):base(options)
        { }


public DbSet<Product> Products { get; set; }
  public DbSet<Category> Categories { get; set; }      
    }
}