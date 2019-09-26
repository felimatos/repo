using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Context;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Dto.Validation;
using Parking.Infra;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IParkingReadRepository, ParkingReadRepository>();

            return services;
        }
    }
}
