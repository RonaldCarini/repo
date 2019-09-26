using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class CarDomainService : ICarDomainService
    {
        private ParkingDataContext _context { get; set; }

        public CarDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(CarDto carDto)
        {
            try
            {
                _context.Car.Add(carDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(CarDto carDto)
        {
            try
            {                
                if (carDto != null)
                {
                    _context.Car.Remove(carDto.DtoToEntity());
                    _context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(CarDto carDto)
        {
            try
            {
                _context.Car.Update(carDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
