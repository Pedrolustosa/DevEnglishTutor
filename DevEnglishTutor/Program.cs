using DevEnglishTutor.Infra.IoC;
using DevEnglishTutor.API.Controllers;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddHttpClient<EnglishTutorController>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureAPI(configuration);
builder.Services.AddInfrastructureSwagger(configuration);

// Configure the HTTP request pipeline.
var app = builder.Build();
if (true)
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "DevEnglishTutor.API v1"));
}
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
