using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Parking.Domain.Mappers
{
    public class ReservationMap : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.ToTable("Reservation");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.AssociateId);
            builder.Property(x => x.CarId);
            builder.Property(x => x.CustomerId);
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.FinalDate).IsRequired();
        }
    }
}
