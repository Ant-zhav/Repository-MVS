namespace Complex742.Models.Equipments
{
    public class TypeEquipment
    {
        public int typeEquipmentId { get; set; }
        public string? nameType { get; set; }
        public ICollection<Property>? propertes { get; set; }
        public ICollection<TypeWork>? typeWorks { get; set; }


    }
}
