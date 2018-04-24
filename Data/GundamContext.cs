using GundamRazor.Models;
using Microsoft.EntityFrameworkCore;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace GundamRazor.Data {
    public class GundamContext : DbContext {
        public GundamContext(DbContextOptions<GundamContext> options) : base(options) { }

        public DbSet<GundamUser> GundamUsers { get; set; }
        public DbSet<MobileSuit> MobileSuits { get; set; }
        public DbSet<ModelKit> ModelKits { get; set; }
        public DbSet<ModelWebpage> ModelWebpages { get; set; }
        public DbSet<Website> Websites { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=gundamrazor;user=gundamuser;password=password");
        }
    }
}