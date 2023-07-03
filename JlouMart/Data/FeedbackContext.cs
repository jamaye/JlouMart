

using JlouMart.Models;
using Microsoft.EntityFrameworkCore;

namespace JlouMart.Data
{
    public class FeedbackContext : DbContext
    {
        public FeedbackContext(DbContextOptions<FeedbackContext> options) : base(options) { }

        //Properties
        public DbSet<Respondent> Respondents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Respondent>().HasKey(k => k.Email).HasName("PrimaryKey_Email");
            modelBuilder.Entity<Respondent>().ToTable("Respondent");
        }

    }
}
