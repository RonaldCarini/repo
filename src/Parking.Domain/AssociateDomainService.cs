using Parking.Domain.Context;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain
{
    public class AssociateDomainService : IAssociateDomainService
    {
        public ParkingDataContext _context { get; set; }
        public AssociateDomainService(ParkingDataContext context)
        {
            _context = context;
        }

        public bool Create(AssociateDto associateDto)
        {
            try
            {
                _context.Associate.Add(new Associate()
                {
                    Agreement = new Agreement()
                    {
                        Description = associateDto.Agreement.Description,
                        DiscountAmount = associateDto.Agreement.DiscountAmount,
                        DiscountPercentage = associateDto.Agreement.DiscountPercentage
                    },
                    Customer = new Customer()
                    {
                        Name = associateDto.Customer.Name,
                        Document = associateDto.Customer.Document,
                        LegalEntity = associateDto.Customer.LegalEntity
                    },                  
                    Quantity = associateDto.Quantity
                }) ;

                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(AssociateDto associateDto)
        {
            throw new NotImplementedException();
        }

        public bool Update(AssociateDto associateDto)
        {
            throw new NotImplementedException();
        }
    }
}
