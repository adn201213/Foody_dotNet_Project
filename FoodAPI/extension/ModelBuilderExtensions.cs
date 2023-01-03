using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FoodAPI.DAL.Entities;
using Microsoft.Extensions.Logging.Configuration;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace FoodAPI.extension
{
    public static class ModelBuilderExtensions
    {
       public static void Seed(this ModelBuilder builder) {
//Create roles List
List<IdentityRole> roles=new List<IdentityRole>(){
 new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
 new IdentityRole { Name = "User", NormalizedName = "USER" }

};
builder.Entity<IdentityRole>().HasData(roles);
// -----------------------------------------------------------------------------
// Seed Users
   var passwordHasher = new PasswordHasher<User>();
List<User> users=new List<User>(){
 // imporant: don't forget NormalizedUserName, NormalizedEmail 
                 new User {
                    UserName = "admin@hotmail.com",
                    NormalizedUserName = "ADMIN@HOTMAIL.COM",
                    Email = "admin@hotmail.com",
                    NormalizedEmail = "ADMIN@HOTMAIL.COM",
                },

                new User {
                    UserName = "adnan@hotmail.com",
                    NormalizedUserName = "ADNAN@HOTMAIL.COM",
                    Email = "adnan@hotmail.com",
                    NormalizedEmail = "ADNAN@HOTMAIL.COM",
                },

};
   users[0].PasswordHash = passwordHasher.HashPassword(users[0], "One+one=222222");
   users[1].PasswordHash = passwordHasher.HashPassword(users[1], "One+one=222222");
 builder.Entity<User>().HasData(users);

  ///----------------------------------------------------

    // Seed UserRoles

    List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
          // Add Password For All Users

     userRoles.Add(new IdentityUserRole<string>{
       UserId=users[0].Id,
       RoleId=roles.FirstOrDefault(q=>q.Name=="Admin").Id});
 userRoles.Add(new IdentityUserRole<string>{
         UserId=users[0].Id,
       RoleId=roles.FirstOrDefault(q=>q.Name=="User").Id});
   userRoles.Add(new IdentityUserRole<string>{
         UserId=users[1].Id,
       RoleId=roles.FirstOrDefault(q=>q.Name=="User").Id});

       builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

///----------------------------------------------------

    // Seed Category

 List<Category> categories=new List<Category>();

categories.Add(new Category{Id=1,CategoryName="Dessert",
ImageCategory="/images/cake.jpg",
UserCreated="Adnan",
DateCreated=DateTime.Now,


});

 
builder.Entity<Category>().HasData(categories);


///----------------------------------------------------

    // Seed Product

    List<Product> products=new List<Product>();
    products.Add(new Product{
      Id=1,
Name="cake1",
ImageUrl="/images/cake.jpg",
Description="From its medieval origins to the digital era, learn ",
TypeFood="sweet",
cuisine="italian",
availabilty=5,
UserCreated="adnan",
DateCreated=DateTime.Today,
Price=100,
CategoryId=1
});


//second product
  products.Add(new Product{
    Id=2,
Name="cake2",
ImageUrl="/images/cake.jpg",
Description="From its medieval origins to the digital era, learn ",
TypeFood="sweet",
cuisine="italian",
availabilty=5,
UserCreated="adnan",
DateCreated=DateTime.Today,
Price=100,
CategoryId=1
});
//
//third product
  products.Add(new Product{
    Id=3,
Name="cake3",
ImageUrl="/images/cake.jpg",
Description="From its medieval origins to the digital era, learn ",
TypeFood="sweet",
cuisine="italian",
availabilty=5,
UserCreated="adnan",
DateCreated=DateTime.Today,
Price=100,
CategoryId=1
});
//third product
  products.Add(new Product{
    Id=4,
Name="cake4",
ImageUrl="/images/cake.jpg",
Description="From its medieval origins to the digital era, learn ",
TypeFood="sweet",
cuisine="italian",
availabilty=5,
UserCreated="adnan",
DateCreated=DateTime.Today,
Price=100,
CategoryId=1
});

builder.Entity<Product>().HasData(products);



       }
    }
}