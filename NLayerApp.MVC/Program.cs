using Microsoft.EntityFrameworkCore;
using NLayerApp.Service.Mapping;
using NLayerApp.Repository.AppDBContext;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using NLayerApp.Web.Modules;
using FluentValidation.AspNetCore;
using NLayerApp.Service.Validations;
using NLayerApp.MVC.Filters;
using NLayerApp.MVC.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region FluentValidation
builder.Services.AddControllersWithViews()
                .AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<ProductDtoValidator>());
#endregion

#region AutoMapper
builder.Services.AddAutoMapper(typeof(MapProfile));
#endregion

#region DbContext
builder.Services.AddDbContext<AppDbContext>(x =>
{
    x.UseSqlServer(builder.Configuration.GetConnectionString("sqlCon"), options =>
    {
        options.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDbContext))?.GetName().Name);
    });
});
#endregion

#region Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(ContainerBuilder => ContainerBuilder.RegisterModule(new RepoServiceModule()));
#endregion

builder.Services.AddScoped(typeof(NotFoundFilter<>));

#region HttpClient
builder.Services.AddHttpClient<ProductApiService>(option =>
{
    option.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);
});

builder.Services.AddHttpClient<CategoryApiService>(option =>
{
    option.BaseAddress = new Uri(builder.Configuration["BaseUrl"]);
});
#endregion

var app = builder.Build();

app.UseExceptionHandler("/Home/Error");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
