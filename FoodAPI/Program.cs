using Microsoft.EntityFrameworkCore;
using FoodAPI.DAL.DataBase;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DbContainer>(opt => {
    opt.UseSqlServer(builder.Configuration.GetConnectionString("FoodyDbConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
 

            //Add AutoMapper
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
