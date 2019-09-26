using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Parking.Domain.Mappers
{
    public class AgreementMap : IEntityTypeConfiguration<Agreement>
    {
        public void Configure(EntityTypeBuilder<Agreement> builder)
        {
            builder.ToTable("Agreement");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(x => x.DiscountAmount).IsRequired().HasColumnType("money");
            builder.Property(x => x.DiscountPercentage).IsRequired();       
        }
    }
}
