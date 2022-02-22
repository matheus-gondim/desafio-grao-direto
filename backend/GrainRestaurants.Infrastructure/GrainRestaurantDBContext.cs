using GrainRestaurants.Core.Entities;
using GrainRestaurants.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;

namespace GrainRestaurants.Infrastructure
{
    public class GrainRestaurantDBContext : DbContext
    {
        public GrainRestaurantDBContext(DbContextOptions options) : base(options) { }

        public DbSet<Dish> Dish { get; set; }
        public DbSet<Password> Password { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<RestaurantType> RestaurantType { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new DishConfigurations())
                .ApplyConfiguration(new PasswordConfigurations())
                .ApplyConfiguration(new RestaurantConfigurations())
                .ApplyConfiguration(new RestaurantTypeConfigurations())
                .ApplyConfiguration(new AddressConfigurations())
                .ApplyConfiguration(new UserConfigurations());
        }
    }
}
