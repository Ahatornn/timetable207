using TimeTable207.Context;
using TimeTable207.Context.Contracts;
using TimeTable207.Repositories.Contracts.Disciplines;
using TimeTable207.Repositories.Implementations;
using TimeTable207.Services.Contracts;
using TimeTable207.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDisciplineService, DisciplineService>();
builder.Services.AddScoped<IDisciplineReadRepository, DisciplineReadRepository>();
builder.Services.AddSingleton<ITimeTableContext, TimeTableContext>();

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
