using Complex742.Models.Equipments;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Complex742.Data
{
    public class DbEquipmentRepository : IRepository<Equipment>
    {
        private readonly Complex742Context _context;
        public DbEquipmentRepository(Complex742Context context)
        {
            _context = context;
        }
        public List<Equipment> list => _context.Equipment.ToList();
        public void Add(Equipment eq)
        { 
            _context.Equipment.Add(eq);
            _context.SaveChanges();
        }
    }
}
