using Assignment1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRouting(options =>
{
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;
});

builder.Services.AddDbContext<ClassContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PageContext")));

// Add service to the container
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddControllersWithViews().AddNewtonsoftJson();

var app = builder.Build();


// Configure the HTTP request pipeline.``
app.UseDeveloperExceptionPage();    
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

//app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapControllerRoute(
       name: "home",
       pattern: "{controller=Home}/{action=Index}/{id?}");
    endpoints.MapControllerRoute(
        name: "about",
        pattern: "{controller=Home}/{action=About}/{id?}");

    endpoints.MapControllerRoute(
        name: "product",
        pattern: "{controller=Product}/{action=List}/{id?}");

    endpoints.MapControllerRoute(
        name: "technician",
        pattern: "{controller=Technician}/{action=List}/{id?}");

    endpoints.MapControllerRoute(
        name: "customer",
        pattern: "{controller=Customer}/{action=List}/{id?}");

    endpoints.MapControllerRoute(
        name: "incident",
        pattern: "{controller=Incident}/{action=List}/{id?}");

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
});

app.Run();
