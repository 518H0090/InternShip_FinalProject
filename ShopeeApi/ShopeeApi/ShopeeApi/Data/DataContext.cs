using Microsoft.EntityFrameworkCore;
using ShopeeApi.Models;

namespace ShopeeApi.Datas
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(x => x.Id);

                user.HasIndex(x => x.UserName).IsUnique();

                user.Property(u => u.Id).UseIdentityColumn();

                user.Property(u => u.UserName).HasColumnType("nvarchar(50)").IsRequired();

                user.Property(u => u.PasswordHash).IsRequired();

                user.Property(u => u.PasswordSalt).IsRequired();
            });
        }
    }
}
