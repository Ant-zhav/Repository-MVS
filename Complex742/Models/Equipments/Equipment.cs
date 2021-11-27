using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complex742.Models.Equipments
{
    public class Equipment
    {
        public int equipmentId { get; set; }
        public Equipment? masterEquipment { get; set; }
        public TypeEquipment? type { get; set; }
        public string? nameEquipment { get; set; }
        public string? modelEquipment { get; set; }
        public string? serialNumberEquipment { get; set; }
        public string? manufactorerEquipment { get; set; }
        public ICollection<PropertyValue>? propertyValues { get; set; }
        public ICollection<Work>? works { get; set; }
    }
}
