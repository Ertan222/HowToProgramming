using FluentValidation;
using HowToProgramming.Data;
using HowToProgramming.Models;
using HowToProgramming.Validators;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<HowToProgrammingDBContext>(db =>
        db.UseNpgsql(builder.Configuration.GetConnectionString("connString"))
        );


builder.Services.AddScoped<IValidator<Creator>,CreatorValidator>();
builder.Services.AddScoped<IValidator<Framework>,FrameworkValidator>();
builder.Services.AddScoped<IValidator<Gender>,GenderValidator>();
builder.Services.AddScoped<IValidator<Language>,LanguageValidator>();
builder.Services.AddScoped<IValidator<LanguageFamily>,LanguageFamilyValidator>();
builder.Services.AddScoped<IValidator<LanguageLevel>,LanguageLevelValidator>();
builder.Services.AddScoped<IValidator<Paradigm>,ParadigmValidator>();
builder.Services.AddScoped<IValidator<Typee>,TypeeValidator>();
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

app.Run();
