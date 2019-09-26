using Parking.Application.Interface;
using Parking.Domain;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class CustomerAppService : ICustomerAppService
    {
        private ICustomerDomainService _customerDomainService { get; set; }
        private ICustomerReadRepository _customerReadRepository { get; set; }

        public CustomerAppService(ICustomerDomainService customerDomainService,
                                  ICustomerReadRepository customerReadRepository)
        {
            _customerDomainService = customerDomainService;
            _customerReadRepository = customerReadRepository;
        }

        public bool Create(CustomerDto customerDto)
        {
            return _customerDomainService.Create(customerDto);
        }

        public bool Update(CustomerDto customerDto)
        {
            return _customerDomainService.Update(customerDto);
        }

        public bool Delete(int id)
        {
            var customerDto = _customerReadRepository.GetById(id);
            return _customerDomainService.Delete(customerDto);
        }

        public List<CustomerDto> GetAll()
        {
            return _customerReadRepository.GetAll();
        }

        public List<CustomerDto> GetAllWithDapper()
        {
            return _customerReadRepository.GetAllWithDapper();
        }

        public CustomerDto GetById(int id)
        {
            return _customerReadRepository.GetById(id);
        }
    }
}
