using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complex742.Models.Equipments
{
    public class Property
    {
        public int propertyId { get; set; }
        public TypeEquipment? typeEquipment {get; set; }
        public string? nameProperty { get; set; }
        public string? unitProperty { get; set; }

    }
}
