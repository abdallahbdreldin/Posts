using InovaInterview.BL.Manager.posts;
using InovaInterview.BL.Manager.Users;
using InovaInterview.DAL.Data.Context;
using InovaInterview.DAL.Data.Repos.Posts;
using InovaInterview.DAL.Data.Repos.Users;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

string? connectionString = builder.Configuration.GetConnectionString("Posts");
builder.Services.AddDbContext<PostsContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddScoped<IuserRepo, UsersRepo>();
builder.Services.AddScoped<IPostsRepo, PostRepo>();

builder.Services.AddScoped<IUsersManager , UsersManager>();
builder.Services.AddScoped<IPostsManager , PostsManager>();



// Add services to the container.

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
