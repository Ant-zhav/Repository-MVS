namespace Complex742.Models.Equipments
{
    public class TypeWork
    {
        public int typeWorkId { get; set; }
        public TypeEquipment? typeEquipment { get; set; }
        public string? nameWork { get; set; }
        public double periodicityWork { get; set; }
        public double laboriousness { get; set; }
    }
}
