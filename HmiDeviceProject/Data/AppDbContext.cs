using HmiDeviceProject.Models;
using Microsoft.EntityFrameworkCore;

namespace HmiDeviceProject.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<DevicesModel> Devices { get; set; }
    public DbSet<StaffsModel> Staffs { get; set; }
    public DbSet<LocationsModel> Locations { get; set; }
    public DbSet<DevRegulationsModel> DevRegulations { get; set; }

}
