using Parking.Application.Interface;
using Parking.Domain.Interface;
using Parking.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Application
{
    public class AssociateAppService : IAssociateAppService
    {
        private IAssociateDomainService _associateDomainService { get; set; }
        public AssociateAppService(IAssociateDomainService associateDomainService)
        {
            _associateDomainService = associateDomainService;
        }

        public bool Create(AssociateDto associateDto)
        {
            return _associateDomainService.Create(associateDto);
        }
    }
}
