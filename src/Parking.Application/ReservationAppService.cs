using Parking.Application.Interface;
using Parking.Common.Extensions;
using Parking.Domain.Interface;
using Parking.Dto;
using Parking.Infra.Interface;
using System.Linq;

namespace Parking.Application
{
    public class ReservationAppService : IReservationAppService
    {
        private ICarReadRepository _carReadRepository { get; set; }
        private IAssociateReadRepository _associateReadRepository { get; set; }
        private ICustomerReadRepository _customerReadRepository { get; set; }
        private IReservationDomainService _reservationDomainService { get; set; }
        private IReservationReadRepository _reservationReadRepository { get; set; }
        private IRateDomainService _rateDomainService { get; set; }
        private IRateReadRepository _rateReadRepository { get; set; }
        public ReservationAppService(ICarReadRepository carReadRepository,
                                     IAssociateReadRepository associateReadRepository,
                                     ICustomerReadRepository customerReadRepository,
                                     IReservationDomainService reservationDomainService,
                                     IReservationReadRepository reservationReadRepository,
                                     IRateDomainService rateDomainService,
                                     IRateReadRepository rateReadRepository)
        {
            _carReadRepository = carReadRepository;
            _associateReadRepository = associateReadRepository;
            _customerReadRepository = customerReadRepository;
            _reservationDomainService = reservationDomainService;
            _reservationReadRepository = reservationReadRepository;
            _rateDomainService = rateDomainService;
            _rateReadRepository = rateReadRepository;
        }

        public bool Post(ReservationDto reservationDto)
        {
            if (reservationDto.CarId > 0)
                reservationDto.Car = _carReadRepository.GetById(reservationDto.CarId);

            if (reservationDto.AssociateId != null)
                reservationDto.Associate = _associateReadRepository.GetById(reservationDto.AssociateId.TryParseToInt32());

            if (reservationDto.CustomerId != null)
                reservationDto.Customer = _customerReadRepository.GetById(reservationDto.CustomerId.TryParseToInt32());

            return _reservationDomainService.Post(reservationDto);
        }
            

        public bool UpdateStatus(int reservationId, int statusId)
        {
            var reservationDto = _reservationReadRepository.GetById(reservationId);
            return _reservationDomainService.UpdateStatus(reservationDto, statusId);
        }

        public ResponseExtractDto GetExtract(int reservationId)
        {
            var customer = _customerReadRepository.GetByReservationId(reservationId);
            var reservation = _reservationReadRepository.GetById(reservationId);

            if (customer == null)
                customer = _associateReadRepository.GetById(reservation.AssociateId.TryParseToInt32())?.Customer;

            var rate = _rateReadRepository.GetAll().LastOrDefault();
            var amount = _rateDomainService.GenerateAmountByType(rate, reservation.Type);

            return new ResponseExtractDto()
            {
                ClientName = customer.Name,
                ReservationId = reservation.Id,
                Period = string.Concat(reservation.StartDate.ToString(), "|", reservation.FinalDate.ToString()),
                Amount = amount,
                RateDescription = rate.Description
            };
        }
    }
}
