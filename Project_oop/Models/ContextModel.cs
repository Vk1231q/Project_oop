using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_oop.Models
{
    public class ContextModel : DbContext
    {
        public DbSet<CityViewModel> CityViewModels { get; set; }
        public DbSet<ClientViewModel> ClientViewModels { get; set; }
        public DbSet<ParcelViewModel> ParcelViewModels { get; set; }
        public DbSet<PersonnelViewModel> PersonnelViewModels { get; set; }
        public DbSet<PostOfficeViewModel> PostOfficeViewModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=Project_oopDB;Integrated Security=True;TrustServerCertificate=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ParcelViewModel>()
                .HasOne(p => p.ReceivingPostOffice)
                .WithMany(po => po.ReceivedParcels)
                .HasForeignKey(p => p.ReceivingPostOfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostOfficeViewModel>()
                .HasMany(po => po.ReceivedParcels)
                .WithOne(p => p.ReceivingPostOffice)
                .HasForeignKey(p => p.ReceivingPostOfficeId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}


