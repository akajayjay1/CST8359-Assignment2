using Assignment_2.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment_2.Data
{
    public class SchoolCommunityContext : DbContext
    {
        public SchoolCommunityContext(DbContextOptions<SchoolCommunityContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<CommunityMembership> CommunityMemberships { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<Community>().ToTable("Community");
            modelBuilder.Entity<Advertisement>().ToTable("Advertisement");
            modelBuilder.Entity<CommunityMembership>().ToTable("CommunityMembership");

            modelBuilder.Entity<CommunityMembership>()
                .HasKey(c => new { c.StudentId, c.CommunityId });
        }
    }
}
