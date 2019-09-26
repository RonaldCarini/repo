using Parking.Domain.Context;
using Parking.Domain.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class CustomerDomainService : ICustomerDomainService
    {
        private ParkingDataContext _context { get; set; }
        
        public CustomerDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(CustomerDto customerDto)
        {
            try
            {
                _context.Customer.Add(customerDto.DtoToEntity());
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(CustomerDto customerDto)
        {
            try
            {                
                if(customerDto != null)
                {
                    _context.Customer.Remove(customerDto.DtoToEntity());
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

        public bool Update(CustomerDto customerDto)
        {
            try
            {
                _context.Customer.Update(customerDto.DtoToEntity());
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
