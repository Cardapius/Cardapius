using Administration.Application;
using Administration.Infra.DataBase.EntityFramework.Extensions;
using BuildingBlock.Application.Extensions;
using BuildingBlock.Domain.ValueObjects.Json.Extensions;
using BuildingBlocks.Api.Extensions;
using BuildingBlocks.Observability.ElasticStack.Extensions;

namespace Administration.Api
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;


            //Microsoft
            builder.Services.AddControllers()
                .AddNewtonsoftJson();
            builder.Services.AddEndpointsApiExplorer();


            //BuildingBlocks
            builder.Services.AddApplicationDomainDataJsonConvert();
            builder.Services.AddApplicationValidation();
            //builder.Services.AddApplicationMediatr();
            builder.Services.AddApplicationSwagger();
            builder.AddObservability(configuration.GetSection("Observability").Bind);


            //Current service
            builder.Services.AddApplication();
            builder.Services.AddInfraDataBaseEntityFramework(configuration);




            var app = builder.Build();

            app.UseObservability();
            app.UseApplicationSwagger();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();



            app.Run();
        }
    }
}

