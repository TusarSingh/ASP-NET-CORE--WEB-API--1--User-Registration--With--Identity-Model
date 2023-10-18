using Radhey.DAL.DatabaseContext;

//using Microsoft.EntityFrameworkCore.SqlServer;                  //          UseSqlServer
using Microsoft.EntityFrameworkCore;                              //          UseSqlServer
using Radhey.DAL.IdentityTables;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();










var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<RadheyDbContext>(options =>
    options.UseSqlServer(connectionString));


builder.Services.AddIdentityCore<TblApplicationUser>().AddEntityFrameworkStores<RadheyDbContext>();
















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

app.UseAuthorization();

app.MapControllers();

app.Run();
