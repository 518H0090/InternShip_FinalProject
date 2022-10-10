using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopeeApi.Models;
using System.Security.Cryptography;
using System.Text;

namespace ShopeeApi.SeedData
{
    public class UserSeed : IEntityTypeConfiguration<User> 
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var user1 = getUserInfor(1, "nhoxhieuro5@gmail.com","468255", Role.Admin);
            var user2 = getUserInfor(2, "chaymetwa", "99546455");
            var user3 = getUserInfor(3,"metmoichua","555422364");
            var user4 = getUserInfor(4, "hoiaita", "152545");

            builder.HasData
            (
                new User
                {
                    Id = user1.Id,
                    UserName = user1.UserName,
                    PasswordSalt = user1.PasswordSalt,
                    PasswordHash = user1.PasswordHash,
                    Role = user1.Role
                },

                new User
                {
                    Id = user2.Id,
                    UserName = user2.UserName,
                    PasswordSalt = user2.PasswordSalt,
                    PasswordHash = user2.PasswordHash,
                    Role = user2.Role
                },


                new User
                {
                    Id = user3.Id,
                    UserName = user3.UserName,
                    PasswordSalt = user3.PasswordSalt,
                    PasswordHash = user3.PasswordHash,
                    Role = user3.Role
                },

                new User
                {
                    Id = user4.Id,
                    UserName = user4.UserName,
                    PasswordSalt = user4.PasswordSalt,
                    PasswordHash = user4.PasswordHash,
                    Role = user4.Role
                }

            );
        }

        private void HashPassword(string password, out byte[] passwordSalt, out byte[] passwordHash)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(Encoding.Unicode.GetBytes(password));
            }
        }

        private User getUserInfor(int userId, string userName, string password, Role role = Role.User)
        {
            HashPassword(password, out byte[] passwordSalt, out byte[] passwordHash);

            var user = new User
            {
                Id = userId,
                UserName = userName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = role
            };

            return user;
        }
    }
}
