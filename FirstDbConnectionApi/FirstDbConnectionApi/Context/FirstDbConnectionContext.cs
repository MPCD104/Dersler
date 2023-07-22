using Microsoft.EntityFrameworkCore;

namespace FirstDbConnectionApi.Context
{
    public class FirstDbConnectionContext : DbContext
    {
        public FirstDbConnectionContext(DbContextOptions<FirstDbConnectionContext> options) : base(options)
        {
            
        }

        public DbSet<WeatherForecast> WeatherForecast { get; set; }

    }
}
