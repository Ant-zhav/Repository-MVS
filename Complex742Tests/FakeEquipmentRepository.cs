using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Complex742.Data;
using Complex742.Models.Equipments;

namespace Complex742Tests
{
    public class FakeEquipmentRepository: IEquipmentRepository
    {
        public IQueryable<Equipment> EquipmentRepository => new List<Equipment> {
            new Equipment {equipmentId = 1, masterEquipment=null, manufactorerEquipment="manufactorer1", modelEquipment="model1", nameEquipment="name1", serialNumberEquipment="number1", type=null, propertyValues=null, works=null },
            new Equipment {equipmentId = 2, masterEquipment=null, manufactorerEquipment="manufactorer2", modelEquipment="model2", nameEquipment="name2", serialNumberEquipment="number2", type=null, propertyValues=null, works=null  },
            new Equipment {equipmentId = 3, masterEquipment=null, manufactorerEquipment="manufactorer3", modelEquipment="model3", nameEquipment="name3", serialNumberEquipment="number3", type=null, propertyValues=null, works=null },
            new Equipment {equipmentId = 4, masterEquipment=null, manufactorerEquipment="manufactorer4", modelEquipment="model4", nameEquipment="name4", serialNumberEquipment="number4", type=null, propertyValues=null, works=null },
            new Equipment {equipmentId = 5, masterEquipment=null, manufactorerEquipment="manufactorer5", modelEquipment="model5", nameEquipment="name5", serialNumberEquipment="number5", type=null, propertyValues=null, works=null }
        }.AsQueryable<Equipment>();
    }
}
