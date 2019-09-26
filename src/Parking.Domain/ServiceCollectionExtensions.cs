using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using Parking.Domain.Context;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Dto.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<ParkingDataContext, ParkingDataContext>();

            services.AddTransient<IAgreementDomainService, AgreementDomainService>();
            services.AddTransient<IAssociateDomainService, AssociateDomainService>();
            services.AddTransient<ICarDomainService, CarDomainService>();
            services.AddTransient<ICustomerDomainService, CustomerDomainService>();
            services.AddTransient<IParkingDomainService, ParkingDomainService>();            
            services.AddTransient<IRateDomainService, RateDomainService>();        

            
            services.AddTransient<IValidator<AgreementDto>, AgreementValidator>();
            //services.AddTransient<IValidator<AssociateDto>, AssociateValidator>();
            services.AddTransient<IValidator<CarDto>, CarValidator>();            
            services.AddTransient<IValidator<CustomerDto>, CustomerValidator>();
            services.AddTransient<IValidator<ParkingDto>, ParkingValidator>();
            services.AddTransient<IValidator<RateDto>, RateValidator>();
            services.AddTransient<IValidator<ReservationDto>, ReservationValidator>();

            return services;
        }
    }
}
