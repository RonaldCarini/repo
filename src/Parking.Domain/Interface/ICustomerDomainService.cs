using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Interface
{
    public interface ICustomerDomainService
    {
        bool Create(CustomerDto customerDto);
        bool Update(CustomerDto customerDto);
        bool Delete(CustomerDto customerDto);
    }
}
