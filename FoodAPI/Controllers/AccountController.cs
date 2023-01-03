using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using  FoodAPI.DAL.Entities;
using FoodAPI.DTO;
using System.Runtime.CompilerServices;
using FoodAPI.Services;

namespace FoodAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
    private readonly UserManager<User> _usermanger;
   
    private readonly TokenService _tokenService;

public AccountController(UserManager<User> usermanger,TokenService tokenService)
{
      _tokenService = tokenService;
      _usermanger = usermanger;
    
}
[HttpPost("login")]
public async Task<ActionResult<UserDto>> Login(LoginDto loginDto){
var user=await _usermanger.FindByNameAsync(loginDto.UserName);
if(user==null||!await _usermanger.CheckPasswordAsync(user,loginDto.Password) ){
    return Unauthorized();
}
return new UserDto{
Email=user.Email,
Token=await _tokenService.GenerateToken(user)


};

}
[HttpPost("register")]
public async Task<ActionResult<User>> Register(RegisterDto registerDto){

var user=new User{UserName=registerDto.UserName,Email=registerDto.Email};

var result=await _usermanger.CreateAsync(user,registerDto.Password);

if(!result.Succeeded){
foreach(var err in result.Errors){
    ModelState.AddModelError(err.Code,err.Description);
}
return ValidationProblem();

}
await _usermanger.AddToRoleAsync(user,"User");
return StatusCode(201);
}


[HttpGet("currentUser")]
public async Task<ActionResult<UserDto>> GetCurrentUser(){

    var user=await _usermanger.FindByNameAsync(User.Identity.Name);
    return new UserDto{
Email=user.Email,
Token=await _tokenService.GenerateToken(user)

    };

}
        
    }
}