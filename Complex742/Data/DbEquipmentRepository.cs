using Complex742.Models.Equipments;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Complex742.Data
{
    public class DbEquipmentRepository: IEquipmentRepository
    {
        private readonly Complex742Context _context;
        

        public DbEquipmentRepository(Complex742Context context)
        {
            _context = context;
            
        }
        IQueryable<Equipment> IEquipmentRepository.EquipmentRepository => GetAllEquipment().Result.AsQueryable<Equipment>();

        public async ValueTask<IEnumerable<Equipment>> GetAllEquipment()
        {
           return await _context.Equipment.ToListAsync();
        }

        

    }
}
