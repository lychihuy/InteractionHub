using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace InteractHub.Infrastructure.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            // Lấy đường dẫn thư mục hiện tại (khi chạy lệnh là thư mục InteractHub.API)
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<AppDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Mình giả định bạn dùng SQL Server. 
            // Nếu bạn dùng PostgreSQL thì đổi thành .UseNpgsql(connectionString) nhé!
            builder.UseSqlServer(connectionString);

            return new AppDbContext(builder.Options);
        }
    }
}