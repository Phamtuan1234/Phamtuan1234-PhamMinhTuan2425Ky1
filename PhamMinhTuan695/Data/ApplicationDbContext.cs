using Microsoft.EntityFrameworkCore;
using PhamMinhTuan695.Controllers;
using PhamMinhTuan695.Models.Entities;
namespace PhamMinhTuan695.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
    {
        public DbSet<Student> Student { get; set; }

    }
}