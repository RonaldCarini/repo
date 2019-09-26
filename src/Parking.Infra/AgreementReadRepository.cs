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
    public class AgreementReadRepository : IAgreementReadRepository
    {
        private ParkingDataContext _context { get; set; }

        public AgreementReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<AgreementDto> GetAll()
        {
            return (from agreement in _context.Agreement
                    select new AgreementDto()
                    {
                        Description = agreement.Description,
                        DiscountAmount = agreement.DiscountAmount,                        
                        DiscountPercentage = agreement.DiscountPercentage
                    }).ToList();
        }

        public List<AgreementDto> GetAllWithDapper()
        {
            var ret = new List<AgreementDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<AgreementDto>("select Id, Description, DiscountAmount, DiscountPercentage from Agreement").ToList();
            }
            return ret;
        }

        public AgreementDto GetById(int id)
        {
            return _context.Agreement
                .Where(x => x.Id == id)
                .Select(x => new AgreementDto
                {
                    Description = x.Description,
                    DiscountAmount = x.DiscountAmount,
                    DiscountPercentage = x.DiscountPercentage
                }).FirstOrDefault();
        }
    }
}
