using Parking.Domain.Context;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking.Infra
{
    public class AssociateReadRepository : IAssociateReadRepository
    {
        public ParkingDataContext _context { get; set; }
        public AssociateReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<AssociateDto> GetAll()
        {
            return (from associate in _context.Associate
                    select new AssociateDto()
                    {
                        Agreement = new AgreementDto()
                        {
                            Description = associate.Agreement.Description,
                            DiscountAmount = associate.Agreement.DiscountAmount,
                            DiscountPercentage = associate.Agreement.DiscountPercentage
                        },
                        Customer = new CustomerDto()
                        {
                            Name = associate.Customer.Name,
                            Document = associate.Customer.Document,
                            LegalEntity = associate.Customer.LegalEntity
                        },
                        Quantity = associate.Quantity                        
                    }).ToList();
        }

        public AssociateDto GetById(int id)
        {
            return _context.Associate
                .Where(x => x.Id == id)
                .Select(x => new AssociateDto
                {
                    Agreement = new AgreementDto()
                    {
                        Description = x.Agreement.Description,
                        DiscountAmount = x.Agreement.DiscountAmount,
                        DiscountPercentage = x.Agreement.DiscountPercentage
                    },
                    Customer = new CustomerDto()
                    {
                        Name = x.Customer.Name,
                        Document = x.Customer.Document,
                        LegalEntity = x.Customer.LegalEntity
                    },
                    Quantity = x.Quantity
                }).FirstOrDefault();
        }
    }
}
