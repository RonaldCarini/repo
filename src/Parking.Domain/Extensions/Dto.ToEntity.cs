using Parking.Dto;

namespace Parking.Domain.Extensions
{
    public static class ExtensionsDto
    {
        public static Agreement DtoToEntity(this AgreementDto agreementDto)
        {
            return new Agreement()
            {
                DiscountAmount = agreementDto.DiscountAmount,
                DiscountPercentage = agreementDto.DiscountPercentage
            };
        }

        public static Car DtoToEntity(this CarDto carDto)
        {
            return new Car()
            {
                LicensePlate = carDto.LicensePlate,
                Model = carDto.Model,
                Year = carDto.Year,
                Color = carDto.Color
            };
        }

        public static Customer DtoToEntity(this CustomerDto customerDto)
        {
            return new Customer()
            {
                Document = customerDto.Document,
                Name = customerDto.Name,
                Address = customerDto.Address,
                Phone = customerDto.Phone,
                LegalEntity = customerDto.LegalEntity
            };
        }

        public static Parking DtoToEntity(this ParkingDto parkingDto)
        {
            return new Parking()
            {
                Address = parkingDto.Address,
                Description = parkingDto.Description,
                Document = parkingDto.Document,
                Phone = parkingDto.Phone
            };
        }

        public static Rate DtoToEntity(this RateDto rateDto)
        {
            return new Rate()
            {
                DailyAmount = rateDto.DailyAmount,
                OvernightAmount = rateDto.OvernightAmount,
                PeriodAmount = rateDto.PeriodAmount
            };
        }

        public static Associate DtoToEntity(this AssociateDto associateDto)
        {
            return new Associate()
            {
                Agreement = associateDto.Agreement.DtoToEntity(),
                Customer = associateDto.Customer.DtoToEntity(),             
                Quantity = associateDto.Quantity
            };
        }

        public static ParkingDto EntityToDto(this Parking parking)
        {
            return new ParkingDto()
            {
                Address = parking.Address,
                Description = parking.Description,
                Document = parking.Document,
                Phone = parking.Phone
            };
        }
    }
}
