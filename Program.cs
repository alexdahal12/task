using JobCandidatesApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<JobCandidatesContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add MVC services for rendering views
builder.Services.AddControllersWithViews();  // Add MVC services for handling views

builder.Services.AddControllers();
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

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // Map API controllers
app.MapControllerRoute( // Map MVC controllers to handle view-related requests
    name: "default",
    pattern: "{controller=Candidate}/{action=Index}/{id?}"
);

