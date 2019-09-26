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
    public class RateReadRepository : IRateReadRepository
    {
        private ParkingDataContext _context { get; set; }
        public RateReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<RateDto> GetAll()
        {
            return (from rate in _context.Rate
                    select new RateDto()
                    {
                        Description = rate.Description,
                        DailyAmount = rate.DailyAmount,
                        PeriodAmount = rate.PeriodAmount,
                        OvernightAmount = rate.OvernightAmount
                    }).ToList();
        }

        public List<RateDto> GetAllWithDapper()
        {
            var ret = new List<RateDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<RateDto>("select Description, DailyAmount, PeriodAmount, OvernightAmount from Rate").ToList();
            }
            return ret;
        }

        public RateDto GetById(int id)
        {
            return _context.Rate
                .Where(x => x.Id == id)
                .Select(x => new RateDto
                {
                    Description = x.Description,
                    DailyAmount = x.DailyAmount,
                    PeriodAmount = x.PeriodAmount,
                    OvernightAmount = x.OvernightAmount
                }).FirstOrDefault();
        }
    }
}
