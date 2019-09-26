using Microsoft.Extensions.DependencyInjection;
using Parking.Application.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAgreementAppService, AgreementAppService>();
            services.AddTransient<IAssociateAppService, AssociateAppService>();
            services.AddTransient<ICarAppService, CarAppService>();
            services.AddTransient<ICustomerAppService, CustomerAppService>();
            services.AddTransient<IParkingAppService, ParkingAppService>();
            services.AddTransient<IRateAppService, RateAppService>();
            services.AddTransient<IReservationAppService, ReservationAppService>();

            return services;
        }
    }
}
