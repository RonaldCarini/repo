using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application.Interface
{
    public interface ICustomerAppService
    {
        bool Create(CustomerDto customerDto);
        bool Update(CustomerDto customerDto);
        bool Delete(int id);
        List<CustomerDto> GetAll();
        List<CustomerDto> GetAllWithDapper();
        CustomerDto GetById(int id);
    }
}
