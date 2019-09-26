using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain
{
    public class AgreementDomainService : IAgreementDomainService
    {
        private ParkingDataContext _context { get; set; }

        public AgreementDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(AgreementDto agreementDto)
        {
            try
            {
                _context.Agreement.Add(agreementDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            } 
        }

        public bool Delete(AgreementDto agreementDto)
        {            
            if(agreementDto != null)
            {
                _context.Agreement.Remove(agreementDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Update(AgreementDto agreementDto)
        {
            try
            {
                _context.Agreement.Update(agreementDto.DtoToEntity());
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
