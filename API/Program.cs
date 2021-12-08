using API;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddOptions<PixConfigOptions>()
              .Configure<IConfiguration>((settings, configuration) =>
              {
                  configuration.GetSection("PixConfigOptions").Bind(settings);
              });

var provider = builder.Services.BuildServiceProvider();
var configOptions = provider.GetRequiredService<IOptions<PixConfigOptions>>();
var pixConfigOptions = configOptions.Value;
builder.Services.AddDbContext<ProjectDbContext>(opt => opt.UseSqlServer(pixConfigOptions.DatabaseConnection, x => x.EnableRetryOnFailure()));

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
