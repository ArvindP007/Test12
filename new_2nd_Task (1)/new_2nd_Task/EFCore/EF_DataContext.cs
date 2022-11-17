using Microsoft.EntityFrameworkCore;
using new_2nd_Task.EFCore;
using System.Reflection.Emit;

namespace Credentials_Module.EFCore
{
    public class EF_DataContext : DbContext
    {
        public EF_DataContext(DbContextOptions<EF_DataContext> options) : base(options) { }
       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserCredentials>()
               .HasOne(b => b.CredentialsInfoTable)
               .WithMany(br => br.UserCredentials)
               .HasForeignKey(b => b.credentialId);

            modelBuilder.Entity<UserCredentials>()
               .HasOne(b => b.Usertable)
               .WithMany(br => br.UserCredentials)
               .HasForeignKey(b => b.UserId);

            
        }
        public DbSet<CredentialsInfoTable> credentialsInfos { get; set; }
        public DbSet<Usertable> usertables { get; set; }
        public DbSet<UserCredentials> userCredentials { get; set; }



    }
}

