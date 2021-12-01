using Complex742.Models.Equipments;

namespace Complex742.Data
{
    public interface IRepository<T> where T : class
    {
        List<T> list { get;}
    }
}
