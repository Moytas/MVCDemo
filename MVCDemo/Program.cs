using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCDemo;
using MVCDemo.Data;
using MVCDemo.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCDemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCDemoContext") ?? throw new InvalidOperationException("Connection string 'MVCDemoContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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

app.MapControllerRoute(
    name: "Privacy",
    pattern: "{controller=Home}/{action=Privacy}/{id?}");


app.MapControllerRoute(
    name: "Info",
    pattern: "{controller=Info}/{action=Show}");

app.MapControllerRoute(
    name: "Create",
    pattern: "{controller=Info}/{action=CreateList}");

app.MapControllerRoute(
    name: "Details",
    pattern: "{controller=Info}/{action=Details}/{id?}");

List<ModelClass> models = new List<ModelClass>(){
    new ModelClass(){ Id = 1, Name = "a"},
    new ModelClass(){ Id = 2, Name = "b"},
    new ModelClass(){ Id = 3, Name = "c"},
    new ModelClass(){ Id=4, Name = "d"}
};

DBManager db = new DBManager();
foreach(var model in models)
{
    db.DBElements.Add(model);
}
db.SaveChanges();
app.Run();
