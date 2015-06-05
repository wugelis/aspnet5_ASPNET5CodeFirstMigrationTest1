using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;

namespace MyCodeFiratAPNET5.Models
{
    public class ClassRoomContext : DbContext
    {
        public DbSet<ClassRoom> ClassRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new Configuration();
            configuration.AddJsonFile("config.json");
            configuration.AddEnvironmentVariables();

            optionsBuilder.UseSqlServer(configuration.Get("Data:DefaultConnection:ConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}