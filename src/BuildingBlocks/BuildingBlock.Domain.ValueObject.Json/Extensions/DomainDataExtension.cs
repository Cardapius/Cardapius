﻿using BuildingBlock.Domain.ValueObject.Json.Configurations;
using BuildingBlock.Domain.ValueObject.Json.Emails;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace BuildingBlock.Domain.ValueObject.Json.Extensions
{
    public static class DomainDataExtension
    {
        public static void AddApplicationDomainData(this IServiceCollection services)
        {
            services.ConfigureOptions<JsonOptionsConfiguration>();
            services.ConfigureOptions<MvcOptionsFormattersConfigure>();

            services.AddTransient<JsonConverter, EmailJsonConverter>();
        }
    }
}
