using Microsoft.EntityFrameworkCore;
using Parking.Domain.Mappers;

namespace Parking.Domain.Context
{
    public class ParkingDataContext: DbContext
    {
        public DbSet<Agreement> Agreement { get; set; }

        public DbSet<Associate> Associate { get; set; }
        public DbSet<Car> Car { get; set; }

        public DbSet<Customer> Customer { get; set; }

        public DbSet<Parking> Parking { get; set; }

        public DbSet<Rate> Rate { get; set; }

        public DbSet<Reservation> Reservation { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Data Source=localhost,1433;Database=parking.database;User ID=sa;Password=cm@123456789;");
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLExpress;Database=parking.database;User ID=sa;Password=cm@123456789;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AgreementMap());
            builder.ApplyConfiguration(new AssociateMap());
            builder.ApplyConfiguration(new CarMap());
            builder.ApplyConfiguration(new CustomerMap());
            builder.ApplyConfiguration(new ParkingMap());
            builder.ApplyConfiguration(new RateMap());
            builder.ApplyConfiguration(new ReservationMap());
        }
    }
}
