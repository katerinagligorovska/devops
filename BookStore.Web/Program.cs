using BookStore.Domain;
using BookStore.Domain.Identity;
using BookStore.Repository;
using BookStore.Repository.Implementation;
using BookStore.Repository.Interface;
using BookStore.Service.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Stripe;

var builder = WebApplication.CreateBuilder(args);

var dbConnStr = Environment.GetEnvironmentVariable("DSN");
if (dbConnStr == null || dbConnStr == "")
{
    dbConnStr = builder.Configuration.GetConnectionString("DefaultConnection");
}

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
options.UseNpgsql(dbConnStr));

builder.Services.AddIdentity<EShopAppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IOrderRepository), typeof(OrderRepository));
builder.Services.Configure<StripeSettings>(builder.Configuration.GetSection("Stripe"));
builder.Services.AddTransient<IBookService, BookStore.Service.Implementation.BookService>();
builder.Services.AddTransient<IShoppingCartService, BookStore.Service.Implementation.ShoppingCartService>();
builder.Services.AddTransient<IOrderService, BookStore.Service.Implementation.OrderService>();
builder.Services.AddTransient<IUserService, BookStore.Service.Implementation.UserService>();

var app = builder.Build();
StripeConfiguration.SetApiKey(builder.Configuration.GetSection("Stripe")["SecretKey"]);
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using var scope = app.Services.CreateAsyncScope();
using var db = scope.ServiceProvider.GetService<ApplicationDbContext>();
db?.Database.MigrateAsync();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapRazorPages();
});

app.Run();
