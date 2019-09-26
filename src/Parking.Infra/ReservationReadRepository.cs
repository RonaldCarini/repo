using Microsoft.EntityFrameworkCore;
using Parking.Common.Extensions;
using Parking.Domain.Context;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Infra
{
    public class ReservationReadRepository : IReservationReadRepository
    {
        private ParkingDataContext _context { get; set; }
        private IAssociateReadRepository _associateReadRepository { get; set; }
        public ICustomerReadRepository _customerReadRepository { get; set; }

        public ReservationReadRepository(ParkingDataContext context,
                                         IAssociateReadRepository associateReadRepository,
                                         ICustomerReadRepository customerReadRepository)
        {
            _context = context;
            _associateReadRepository = associateReadRepository;
            _customerReadRepository = customerReadRepository;
        }

        public ReservationDto GetById(int id)
        {
            var dto = _context.Reservation
                            .Include(x => x.Associate)
                            .Include(x => x.Car)
                            .Include(x => x.Customer)
                            .Where(x => x.Id == id)
                            .Select(x => new ReservationDto
                            {
                                Id = x.Id,
                                AssociateId = x.Associate.Id,
                                CarId = x.Car.Id,
                                Car = new CarDto()
                                {
                                    Id = x.Car.Id,
                                    Color = x.Car.Color,
                                    LicensePlate = x.Car.LicensePlate,
                                    Model = x.Car.Model,
                                    Year = x.Car.Year
                                },
                                CustomerId = x.Customer.Id,
                                Status = x.Status,
                                Type = x.Type,
                                StartDate = x.StartDate,
                                FinalDate = x.FinalDate
                            }).FirstOrDefault();

            if (dto.AssociateId != null)
                dto.Associate = _associateReadRepository.GetById(dto.AssociateId.TryParseToInt32());

            if (dto.CustomerId != null)
                dto.Customer = _customerReadRepository.GetById(dto.CustomerId.TryParseToInt32());

            return dto;
        }
    }
}
