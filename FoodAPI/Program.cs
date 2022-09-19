using Microsoft.EntityFrameworkCore;
using FoodAPI.DAL.DataBase;
using FoodAPI.BL.Interface;
using FoodAPI.BL.Interface.Repository;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using FoodAPI.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using FoodAPI.Services;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContainer>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("FoodyDbConnection"));
});
builder.Services.AddControllers();

 builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Jwt auth header",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header
                        },
                        new List<string>()
                    }
                });
            });





builder.Services.AddCors();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddScoped<IProduct,ProductRepo>();

builder.Services.AddScoped<TokenService>();

builder.Services.AddSwaggerGen();
 
builder.Services.AddIdentityCore<User>(opt=>
{opt.User.RequireUniqueEmail=true;
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<DbContainer>();
   builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                            .GetBytes(builder.Configuration["JWTSettings:TokenKey"]))
                    };
                });
builder.Services.AddAuthorization();


            //Add AutoMapper
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
   // app.UseSwaggerUI();
     app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
}

//app.UseHttpsRedirection();
app.UseCors(opt=>opt.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000"));
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
