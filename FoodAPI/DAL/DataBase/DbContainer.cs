using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FoodAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using FoodAPI.extension;

namespace FoodAPI.DAL.DataBase
{
    public class DbContainer:IdentityDbContext<User>
    {
    

 public DbContainer(DbContextOptions<DbContainer> options):base(options)
        { }


public DbSet<Product> Products { get; set; }
  public DbSet<Category> Categories { get; set; }  



  protected override void OnModelCreating(ModelBuilder builder)  
        {  
            base.OnModelCreating(builder);  
             builder.Seed() ;
        }
private void seedUserAndRole(ModelBuilder builder){
var memberRole=new IdentityRole { 
            Name = "Member", 
            NormalizedName = "MEMBER", 
          
};
     builder.Entity<IdentityRole>().HasData(memberRole);


var adminRole=new IdentityRole { 
            Name = "Admin", 
            NormalizedName = "ADMIN", 
          
           
           };


        //seed admin role
           builder.Entity<IdentityRole>().HasData(adminRole);

 //create user
           var memberUser = new User { 
      
            Email = "adn@hotmail.com",
            EmailConfirmed = true, 
            
            UserName = "adn@hotmail.com",
            NormalizedUserName = "ADN@HOTMAIL.COM"
           };


 //set user password
          PasswordHasher<User> ph = new PasswordHasher<User>();
          memberUser.PasswordHash = ph.HashPassword(memberUser,"One+one=222222");

   //create user
           var adminuser = new User { 
          
            Email = "admin@hotmail.com",
            EmailConfirmed = true, 
            
            UserName = "admin@hotmail.com",
            NormalizedUserName = "ADMIN@HOTMAIL.COM"
           };


 //set user password
          PasswordHasher<User> ph1 = new PasswordHasher<User>();
          adminuser.PasswordHash = ph1.HashPassword(adminuser,"One+one=222222");

          //seed user
          builder.Entity<User>().HasData(adminuser,memberUser);

             builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string> { 
           RoleId = adminRole.Id , 
           UserId = adminuser.Id 
          },new IdentityUserRole<string> { 
           RoleId = memberRole.Id, 
           UserId = memberUser.Id 
          });

}


   
 

        }



    


    }
