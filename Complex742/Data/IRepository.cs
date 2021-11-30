using Complex742.Models.Equipments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Complex742.Data
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll();
    }
}
