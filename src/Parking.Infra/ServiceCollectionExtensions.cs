using Microsoft.Extensions.DependencyInjection;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Infra
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfra(this IServiceCollection services)
        {
            services.AddTransient<IAgreementReadRepository, AgreementReadRepository>();
            services.AddTransient<IAssociateReadRepository, AssociateReadRepository>();
            services.AddTransient<ICarReadRepository, CarReadRepository>();
            services.AddTransient<ICustomerReadRepository, CustomerReadRepository>();
            services.AddTransient<IParkingReadRepository, ParkingReadRepository>();
            services.AddTransient<IRateReadRepository, RateReadRepository>();
            services.AddTransient<IReservationReadRepository, ReservationReadRepository>();

            return services;
        }
    }
}
