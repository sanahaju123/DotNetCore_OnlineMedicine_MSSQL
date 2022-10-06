using Microsoft.EntityFrameworkCore;
using OnlineMedicineShopping.Entities;
using System;

namespace OnlineMedicineShopping.DataLayer
{
    public class MedicineDbContext : DbContext
    {
        public MedicineDbContext(DbContextOptions<MedicineDbContext> dbContextOptions)
            : base(dbContextOptions)
        {
            //Database.Migrate();
        }
        /// <summary>
        /// Creating DbSet for Table
        /// </summary>
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<MedicineOrder> productOrders { get; set; }
       
    }
}
