using Dapper;
using Microsoft.EntityFrameworkCore;
using Parking.Domain.Context;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Infra
{
    public class CarReadRepository : ICarReadRepository
    {
        private ParkingDataContext _context { get; set; }
        public CarReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<CarDto> GetAll()
        {
            return (from car in _context.Car
                    select new CarDto()
                    {
                        LicensePlate = car.LicensePlate,
                        Model = car.Model,
                        Year = car.Year,
                        Color = car.Color
                    }).ToList();
        }

        public List<CarDto> GetAllWithDapper()
        {
            var ret = new List<CarDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<CarDto>("select Id, LicensePlate, Model, Year, Color from Car").ToList();
            }
            return ret;
        }

        public CarDto GetById(int id)
        {
            return _context.Car
                .Where(x => x.Id == id)
                .Select(x => new CarDto
                {
                    LicensePlate = x.LicensePlate,
                    Model = x.Model,
                    Year = x.Year,
                    Color = x.Color
                }).FirstOrDefault();
        }
    }
}
