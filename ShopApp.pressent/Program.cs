using Microsoft.Data.SqlClient;
using ShopApp.Application.Interface.Categoria;
using ShopApp.Application.Interface.Customers;
using ShopApp.Application.Interface.OrderDetails;
using ShopApp.Application.Service.CategoriaService;
using ShopApp.Application.Service.CustomerService;
using ShopApp.Application.Service.OrderDetailsService;
using ShopApp.Domain.Interface.Categoria;
using ShopApp.Domain.Interface.Customers;
using ShopApp.Domain.Interface.OrderDetails;
using ShopApp.Percistence.Repositories.Categoria;
using ShopApp.Percistence.Repositories.Customers;
using ShopApp.Percistence.Repositories.OrderDetails;

namespace ShopApp.pressent
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
            builder.Services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();

            builder.Services.AddScoped<ICategoriaService, CategoriaService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IOrderDetailsService, OrderDetailsService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
