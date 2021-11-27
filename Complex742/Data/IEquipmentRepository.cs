using Complex742.Models.Equipments;

namespace Complex742.Data
{
    public interface IEquipmentRepository
    {
        IQueryable<Equipment> EquipmentRepository { get; }
    }
}
