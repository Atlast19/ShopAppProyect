using ShopApp.Application.Interface.Categoria;
using ShopApp.Application.Interface.Customers;
using ShopApp.Application.Interface.Employees;
using ShopApp.Application.Interface.Order;
using ShopApp.Application.Interface.OrderDetails;
using ShopApp.Application.Interface.Products;
using ShopApp.Application.Interface.Shippers;
using ShopApp.Application.Interface.Suppliers;
using ShopApp.Application.Service.CategoriaService;
using ShopApp.Application.Service.CustomerService;
using ShopApp.Application.Service.EmployeesService;
using ShopApp.Application.Service.OrderDetailsService;
using ShopApp.Application.Service.OrderService;
using ShopApp.Application.Service.ProductsService;
using ShopApp.Application.Service.ShipperService;
using ShopApp.Application.Service.SupplierService;
using ShopApp.Domain.Interface.Categoria;
using ShopApp.Domain.Interface.Customers;
using ShopApp.Domain.Interface.Employees;
using ShopApp.Domain.Interface.OrderDetails;
using ShopApp.Domain.Interface.Product;
using ShopApp.Domain.Interface.Shippers;
using ShopApp.Domain.Interface.Suppliers;
using ShopApp.Domain.Interface;
using ShopApp.Percistence.Repositories.Categoria;
using ShopApp.Percistence.Repositories.Customers;
using ShopApp.Percistence.Repositories.Employees;
using ShopApp.Percistence.Repositories.Order;
using ShopApp.Percistence.Repositories.OrderDetails;
using ShopApp.Percistence.Repositories.Shippers.Products;
using ShopApp.Percistence.Repositories.Shippers;
using ShopApp.Percistence.Repositories.Suppliers;

namespace ShopApp.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            builder.Services.AddScoped<ICustomersRepository, CustomersRepository>();
            builder.Services.AddScoped<IOrderDetailsRepository, OrderDetailsRepository>();
            builder.Services.AddScoped<IEmployeesRepository, EmployeesRepository>();
            builder.Services.AddScoped<IShippersRepository, ShippersRepository>();
            builder.Services.AddScoped<IProductsRepository, ProductsRepository>();
            builder.Services.AddScoped<ISuppliersRepository, SuppliersRepository>();
            builder.Services.AddScoped<IOrderService, OrderService>();

            builder.Services.AddScoped<ICategoriaService, CategoriaService>();
            builder.Services.AddScoped<ICustomerService, CustomerService>();
            builder.Services.AddScoped<IOrderDetailsService, OrderDetailsService>();
            builder.Services.AddScoped<IProductsService, ProductsService>();
            builder.Services.AddScoped<IShippersService, ShippersService>();
            builder.Services.AddScoped<ISuppliersService, SupplierService>();
            builder.Services.AddScoped<IEmployeesService, EmployeesService>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
