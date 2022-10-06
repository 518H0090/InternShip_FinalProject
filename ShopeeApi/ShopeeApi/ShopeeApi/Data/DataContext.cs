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
        public DbSet<Restaurant> Restaurants { set; get; }
        public DbSet<Category> Categories { set; get; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //User 
            modelBuilder.Entity<User>(user =>
            {
                user.HasKey(x => x.Id);

                user.HasIndex(x => x.UserName).IsUnique();

                user.Property(u => u.Id).UseIdentityColumn();

                user.Property(u => u.UserName).HasColumnType("nvarchar(50)").IsRequired();

                user.Property(u => u.PasswordHash).IsRequired();

                user.Property(u => u.PasswordSalt).IsRequired();
            });

            //Restaurant
            modelBuilder.Entity<Restaurant>(res =>
            {
                res.HasKey(x => x.RsId);

                res.HasIndex(x => x.RsTitle).IsUnique();

                res.Property(x => x.RsId).UseIdentityColumn();

                res.Property(x => x.RsTitle).HasColumnType("nvarchar(100)").IsRequired();

                res.Property(x => x.RsProvince).HasColumnType("nvarchar(200)").IsRequired();

                res.Property(x => x.RsAddress).HasColumnType("nvarchar(200)").IsRequired();

                res.Property(x => x.RsType).HasColumnType("nvarchar(30)").IsRequired();

                res.Property(x => x.RsImageUrl).HasColumnType("nvarchar(600)").IsRequired();

                res.Property(x => x.RsStar).HasDefaultValue<float>(1);

                res.Property(x => x.RsReviews).HasDefaultValue<int>(0);

                res.Property(x => x.RsOpenTime).HasColumnType("nvarchar(100)").IsRequired();
            
                res.Property(x => x.RsPrinceRange).HasColumnType("nvarchar(800)").IsRequired();

                res.Property(x => x.RsRefeLike).HasDefaultValue<bool>(false);

                res.Property(x => x.RsPromotion).IsRequired();

                res.HasMany<Category>(res => res.Categories)
                .WithOne(cate => cate.Restaurant)
                .HasForeignKey(cate => cate.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);

            });

            //Restaurant Category
            modelBuilder.Entity<Category>(cate =>
            {
                cate.HasKey(x => x.CategoryId);

                cate.HasIndex(x => new { x.CategoryTag, x.RestaurantId }).IsUnique();

                cate.Property(x => x.CategoryId).UseIdentityColumn();

                cate.Property(x => x.CategoryName).HasColumnType("nvarchar(200)").IsRequired();

                cate.Property(x => x.CategoryTag).HasColumnType("nvarchar(50)").IsRequired();

                cate.HasOne<Restaurant>(cate => cate.Restaurant)
                .WithMany(res => res.Categories)
                .HasForeignKey(cate => cate.RestaurantId)
                .OnDelete(DeleteBehavior.Cascade);
            });

        }

        
    }
}