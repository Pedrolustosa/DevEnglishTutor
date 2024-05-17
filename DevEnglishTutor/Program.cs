using Serilog;
using DevEnglishTutor.Infra.IoC;

var appName = "ChatGPT ASP.NET 8 Integration";
var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddInfrastructureAPI(configuration);
builder.Services.AddInfrastructureChatGPT(configuration);
builder.Services.AddInfrastructureSwagger(configuration);
builder.Services.AddInfrastructureSerilog(configuration, appName);
builder.Logging.ClearProviders();
builder.Host.UseSerilog(Log.Logger, true);

// Configure the HTTP request pipeline.
var app = builder.Build();
app.AddInfrastructureSwaggerUI(appName);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
