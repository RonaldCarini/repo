using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain
{
    public class RateDomainService : IRateDomainService
    {
        private ParkingDataContext _context { get; set; }

        public RateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(RateDto rateDto)
        {
            try
            {
                _context.Rate.Add(rateDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(RateDto rateDto)
        {
            try
            {                
                if (rateDto != null)
                {
                    _context.Rate.Remove(rateDto.DtoToEntity());
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

        public bool Update(RateDto rateDto)
        {
            try
            {
                _context.Rate.Update(rateDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public decimal GenerateAmountByType(RateDto rate, int type)
        {
            // Calcula o periodo de acordo com o tipo

            return (type == 0 ? rate.DailyAmount :
                        type == 1 ? rate.OvernightAmount :
                          type == 2 ? rate.PeriodAmount : rate.DailyAmount);
        }
    }
}
