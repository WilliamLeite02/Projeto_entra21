using AjudaFacil.Data.Mappings;
using AjudaFacilV2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AjudaFacilV2.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Donation> Donations { get; set; }
    public DbSet<ClothingDonation> ClothingDonations { get; set; }
    public DbSet<SchoolSupplieDonation> SchoolSupplieDonations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new DonationMap());
        modelBuilder.ApplyConfiguration(new ClothingDonationMap());
        modelBuilder.ApplyConfiguration(new SchoolSupplieDonationMap());
    }
}
