using FaculdadeApp_Backend.src.Infrastructure.Database;
using FaculdadeApp_Backend.src.pieces.semestres.repositories;
using FaculdadeApp_Backend.src.pieces.semestres.services;
using FaculdadeApp_Backend.src.pieces.cadeiras.services;
using FaculdadeApp_Backend.src.pieces.cadeiras.repositories;


using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddControllers().AddJsonOptions(options =>
// {
//     options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
// });


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
    options.LogTo(Console.WriteLine, LogLevel.Information);
});


builder.Services.AddScoped<ISemestreRepository, SemestreRepository>();
builder.Services.AddScoped<ISemestreService, SemestreService>();
builder.Services.AddScoped<ICadeiraRepository, CadeiraRepository>();
builder.Services.AddScoped<ICadeiraService, CadeiraService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
