using Dapper.HappyEvents.Application.Interfaces;
using Dapper.HappyEvents.Persistance.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IBlogService, BlogRepository>();
builder.Services.AddScoped<IFeatureService, FeatureRepository>();
builder.Services.AddScoped<IServiceService, ServiceRepository>();
builder.Services.AddScoped<ITeamService, TeamRepository>();
builder.Services.AddScoped<ITestimonialService, TestimonialRepository>();

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
