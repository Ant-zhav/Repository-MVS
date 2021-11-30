using Complex742.Models.Equipments;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Complex742.Data
{
    public class DbEquipmentRepository : IRepository<Equipment>
    {
        private readonly Complex742Context _context;
        public DbEquipmentRepository(Complex742Context context)
        {
            _context = context;

        }

        public async Task<List<Equipment>> GetAll()
        {
            return await _context.Equipment.ToListAsync();
        }
    }
}
