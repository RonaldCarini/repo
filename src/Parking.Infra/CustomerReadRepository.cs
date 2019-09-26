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
    public class CustomerReadRepository : ICustomerReadRepository
    {
        private ParkingDataContext _context { get; set; }
        public CustomerReadRepository(ParkingDataContext context)
        {
            _context = context;
        }

        public List<CustomerDto> GetAll()
        {
            return (from customer in _context.Customer
                    select new CustomerDto()
                    {
                        Name = customer.Name,
                        Document = customer.Document,
                        Address = customer.Address,
                        Phone = customer.Phone,
                        LegalEntity = customer.LegalEntity
                    }).ToList();
        }

        public List<CustomerDto> GetAllWithDapper()
        {
            var ret = new List<CustomerDto>();

            using (var connection = _context.Database.GetDbConnection())
            {
                ret = connection.Query<CustomerDto>("select Id, Name, Document, Address, Phone, LegalEntity from Customer").ToList();
            }
            return ret;
        }

        public CustomerDto GetById(int id)
        {
            return _context.Customer
                .Where(x => x.Id == id)
                .Select(x => new CustomerDto
                {
                    Name = x.Name,
                    Document = x.Document,
                    Address = x.Address,
                    Phone = x.Phone,
                    LegalEntity = x.LegalEntity
                }).FirstOrDefault();
        }

        public CustomerDto GetByReservationId(int reservationId)
        {
            return (from customer in _context.Customer
                    join reservation in _context.Reservation on customer.Id equals reservation.CustomerId
                    where reservation.Id == reservationId
                    select new CustomerDto()
                    {
                        Id = customer.Id,
                        Name = customer.Name,
                        Document = customer.Document,
                        LegalEntity = customer.LegalEntity
                    }).FirstOrDefault();
        }
    }
}
