using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace APIs.Model
{
    public class UserContext :DbContext
    {

        public UserContext() : base() { }
        public UserContext(DbContextOptions<UserContext> options) : base(options) { }






        public DbSet<User> Users { get; set; }
        public DbSet<UserAddress> Address { get; set; }


        
        public DbSet<City> City { get; set; }

        public DbSet<Governorate> Governorate { get; set; }
        public DbSet<UserCount> UserCounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-E496IEJ;Initial Catalog=User;Integrated Security=True");
            base.OnConfiguring(optionsBuilder);
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // seeding for Governorate and cities
            modelBuilder.Entity<Governorate>().HasData(
                new Governorate { Id = 1, Name = "Cairo" },
                new Governorate { Id = 2, Name = "Giza" },
                new Governorate { Id = 3, Name = "Alexandria" }
            );

modelBuilder.Entity<City>().HasData(
    // Cities for Cairo
    new City { Id = 1, Name = "Cairo Downtown", GovernorateId = 1 },
    new City { Id = 2, Name = "Zamalek", GovernorateId = 1 },
    new City { Id = 3, Name = "Kasr El Nile", GovernorateId = 1 },
    new City { Id = 4, Name = "Rehab", GovernorateId = 1 },
    new City { Id = 5, Name = "Katameya", GovernorateId = 1 },
    new City { Id = 6, Name = "Madinty", GovernorateId = 1 },
    new City { Id = 7, Name = "Rod Alfarag", GovernorateId = 1 },
    new City { Id = 8, Name = "Sheraton", GovernorateId = 1 },
    new City { Id = 9, Name = "El-Gamaleya", GovernorateId = 1 },
    new City { Id = 10, Name = "10th of Ramadan City", GovernorateId = 1 },
    new City { Id = 11, Name = "Helmeyat Alzaytoun", GovernorateId = 1 },
    new City { Id = 12, Name = "New Nozha", GovernorateId = 1 },
    new City { Id = 13, Name = "Capital New", GovernorateId = 1 },

    // Cities for Giza
    new City { Id = 14, Name = "السادس من أكتوبر", GovernorateId = 2 },
    new City { Id = 15, Name = "Sixth of October", GovernorateId = 2 },
    new City { Id = 16, Name = "Cheikh Zayed", GovernorateId = 2 },
    new City { Id = 17, Name = "Hawamdiyah", GovernorateId = 2 },
    new City { Id = 18, Name = "Al Badrasheen", GovernorateId = 2 },
    new City { Id = 19, Name = "Saf", GovernorateId = 2 },
    new City { Id = 20, Name = "Atfih", GovernorateId = 2 },
    new City { Id = 21, Name = "Al Ayat", GovernorateId = 2 },
    new City { Id = 22, Name = "Al-Bawaiti", GovernorateId = 2 },
    new City { Id = 23, Name = "ManshiyetAl Qanater", GovernorateId = 2 },
    new City { Id = 24, Name = "Oaseem", GovernorateId = 2 },
    new City { Id = 25, Name = "Kerdasa", GovernorateId = 2 },

    // Cities for Alexandria
    new City { Id = 26, Name = "ابو قير", GovernorateId = 3 },
    new City { Id = 27, Name = "Abu Qir", GovernorateId = 3 },
    new City { Id = 28, Name = "Al Ibrahimeyah", GovernorateId = 3 },
    new City { Id = 29, Name = "Azarita", GovernorateId = 3 },
    new City { Id = 30, Name = "Anfoushi", GovernorateId = 3 },
    new City { Id = 31, Name = "Dekheila", GovernorateId = 3 },
    new City { Id = 32, Name = "El Soyof", GovernorateId = 3 },
    new City { Id = 33, Name = "Ameria", GovernorateId = 3 },
    new City { Id = 34, Name = "El Labban", GovernorateId = 3 },
    new City { Id = 35, Name = "Al Mafrouza", GovernorateId = 3 },
    new City { Id = 36, Name = "El Montaza", GovernorateId = 3 },
    new City { Id = 37, Name = "Mansheya", GovernorateId = 3 },
    new City { Id = 38, Name = "Naseria", GovernorateId = 3 },
    new City { Id = 39, Name = "Ambrozo", GovernorateId = 3 }
);

base.OnModelCreating(modelBuilder);

            // Seed initial UserCount
            modelBuilder.Entity<UserCount>().HasData(new UserCount { Id = 1, Count = 0 });

        }
}
    }
