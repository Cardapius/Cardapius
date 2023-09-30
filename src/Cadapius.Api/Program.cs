using Administration.Api.Extensions;
using BuildingBlock.Api.Domain.ValueObjects.Json.Extensions;
using BuildingBlock.Api.Application.Extensions;
using BuildingBlock.Api.Swashbuckle.Extensions;
using BuildingBlock.Api.Version.Extensions;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;




// Add services to the container.

builder.Services.AddControllers()
    .AddAdministrationService();
builder.Services.AddProblemDetails();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddApplicationVersion();

//BuildingBlocks
builder.Services.AddApplicationDomainDataJsonConvert();
builder.Services.AddApplicationValidation();
//builder.Services.AddApplicationMediatr();
builder.Services.AddApplicationSwagger();
//builder.AddObservability(configuration.GetSection("Observability").Bind);


//Add services to the container.
builder.AddAdministrationService(configuration);





var app = builder.Build();
//app.UseObservability();
app.UseApplicationSwagger();

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