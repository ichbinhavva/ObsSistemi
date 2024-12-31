using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulWebProjectSube2
{
    internal class StudentDBContext : DbContext
    {
        public DbSet<Students>? Ogrenciler { get; set; }
        public DbSet<Sinif>? Siniflar { get; set; }
        public DbSet<OgrenciDers>? OgrenciDersler { get; set; }
        public DbSet<Ders>? Dersler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=OgrenciDbSube2EF; Integrated Security=true; TrustServerCertificate=true");//Bu database ismiyle kendi yaratacak
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<OgrenciDers>()
       .HasKey(od => new { od.OgrenciId, od.DersId }); 

            // OgrenciDersler -> Dersler İlişkisi
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ders) 
                .WithMany(d => d.OgrenciDersler) 
                .HasForeignKey(od => od.DersId); // Foreign Key: DersId

            // OgrenciDersler -> Ogrenciler İlişkisi
            modelBuilder.Entity<OgrenciDers>()
                .HasOne(od => od.Ogrenci) // OgrenciDersler.Ogrenciler
                .WithMany(o => o.OgrenciDersler)
                .HasForeignKey(od => od.OgrenciId); // Foreign Key: OgrenciId

            // Ogrenciler -> Siniflar İlişkisi
            modelBuilder.Entity<Students>()
                .HasOne(o => o.Sinif) // Ogrenciler.Siniflar
                .WithMany(s => s.Ogrenciler) 
                .HasForeignKey(o => o.SinifId); // Foreign Key: SinifId
        }
    }
}
