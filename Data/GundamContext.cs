using GundamRazor.Models;
using Microsoft.EntityFrameworkCore;

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
            optionsBuilder.UseMySql(@"Server=localhost;database=gundamrazor;uid=gundamuser;pwd=password");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<WishlistItem>().HasKey(t => new { t.ModelKitID, t.GundamUserID });
        }
    }
}