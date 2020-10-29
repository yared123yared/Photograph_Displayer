using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<T>
    {
        Task<List<T>> GetData();
        Task<T> GetDataById(int id);
        Task<T> GetDataByEmail(string email);
        Task<T> UpdateData(T student);
        Task<bool> DeleteData(T student);

    }
}