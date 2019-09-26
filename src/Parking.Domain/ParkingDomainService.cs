using System.Collections.Generic;
using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;

namespace Parking.Domain
{
    public class ParkingDomainService : IParkingDomainService
    {
        private ParkingDataContext _context { get; set; }       

        public ParkingDomainService(ParkingDataContext context)
        {
            _context = context;           
        }
        public bool Create(ParkingDto parkingDto)
        {
            try
            {
                //_context.Parking.Add(parking);

                //_context.Parking.Add(new Parking()
                //{
                //    Address = parkingDto.Address,
                //    Description = parkingDto.Description,
                //    Document = parkingDto.Document,
                //    Phone = parkingDto.Phone
                //});

                _context.Parking.Add(parkingDto.DtoToEntity());
                               
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(ParkingDto parkingDto)
        {
            try
            {
                if(parkingDto != null)
                {
                    _context.Parking.Remove(parkingDto.DtoToEntity());
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

        public bool Update(ParkingDto parkingDto)
        {
            try
            {
                //_context.Parking.Update(parking);
                _context.Parking.Update(parkingDto.DtoToEntity());
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
