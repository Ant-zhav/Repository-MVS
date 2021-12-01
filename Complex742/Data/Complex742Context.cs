using Microsoft.EntityFrameworkCore;

namespace Complex742.Data
{
    public class Complex742Context : DbContext
    {
        public Complex742Context()

        {
        }

        public Complex742Context(DbContextOptions<Complex742Context> options) : base(options)
        {
        }

        public DbSet<Complex742.Models.Equipments.Equipment>? Equipment { get; set; }
        public DbSet<Complex742.Models.Equipments.TypeEquipment>? TypeEquipment { get; set; }
        public DbSet<Complex742.Models.Equipments.Work>? Work { get; set; }
        public DbSet<Complex742.Models.Equipments.TypeWork>? TypeWork { get; set; }
        public DbSet<Complex742.Models.Equipments.Property>? Property { get; set; }
        public DbSet<Complex742.Models.Equipments.PropertyValue>? PropertyValue { get; set; }
    }
}
