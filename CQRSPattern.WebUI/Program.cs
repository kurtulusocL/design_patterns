using CQRSPattern.Business.DependencyInjection.CQRS;
using CQRSPattern.Business.DependencyInjection.mediatR;
using CQRSPattern.Business.DependencyInjection.RepositoryPattern;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.CQRSContainerDependencies();
builder.Services.ContainerDependencies();
builder.Services.mediatRContainerDependencies();

var app = builder.Build();

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