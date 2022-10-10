using Microsoft.EntityFrameworkCore;
using ShopeeApi.Datas;

namespace ShopeeApi.SeedData
{
    public static class MigrationInialtial
    {
        public static WebApplication MigrateDatabase(this WebApplication webApp)
        {
            using (var scope = webApp.Services.CreateScope())
            {
                using (var appContext = scope.ServiceProvider.GetRequiredService<DataContext>())
                {
                    try
                    {
                        appContext.Database.Migrate();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            return webApp;
        }
    }
}
