using EcommerceWebAPPService;
using EcommerceWebAPPService.ContextClass;
using EcommerceWebAPPService.Model;
using EcommerceWebAPPService.Model.Context;
using EcommerceWebAPPService.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<EcomContext>(options => options.UseSqlServer(builder
    .Configuration.GetConnectionString("Devconnection")));

builder.Services.AddScoped<IECOMService<Product>,ProductService>();
builder.Services.AddScoped<IECOMService<UserDetails>, UserService>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.MapFallbackToFile("index.html");

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Product}/{action=GetAllProducts}/{id?}");


app.MapControllers();

app.Run();
