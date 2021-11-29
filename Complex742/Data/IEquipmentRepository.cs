using Complex742.Models.Equipments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Complex742.Data
{
    public interface IEquipmentRepository
    {
        Task<List<Equipment>> GetAll();
    }
}
