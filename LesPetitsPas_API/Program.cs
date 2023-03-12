using LesPetitsPas_DAL.Interfaces;
<<<<<<< HEAD
using LesPetitsPas_DAL.Repositories;
=======
>>>>>>> 575311a850e15a587e40c8a926e49d8966ff1b8e
using Tools.Ado;
using LesPetitsPas_DAL.Repositories;

var builder = WebApplication.CreateBuilder(args);

IConfiguration configuration = builder.Configuration;
// Add services to the container.
builder.Services.AddHttpClient("Api", client =>
{
    client.BaseAddress = new Uri(configuration["Api"]);
});
builder.Services.AddScoped<IBusRepository,BusRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient(c => new Connection(
    builder.Configuration.GetConnectionString("default")
    ));

builder.Services.AddScoped<IChildRepository, ChildRepository>();
builder.Services.AddScoped<IPersonRepository, PersonRepository>();
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

Console.WriteLine("Hello World");