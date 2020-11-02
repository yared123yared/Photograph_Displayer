using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data
{
    public interface IRepository<T>
    {
        Task<List<T>> GetData();
        Task<T> GetDataById(int id);
        Task<T> GetDataByEmail(string email);

        Task<List<T>> GetPhotosByEmail(string email);
        Task<T> UpdateData(T student);
        Task<bool> DeleteData(T student);
        Task<List<T>> GetLoggedInUsers();
        Task<T> InsertLoggedInUser(T student);


    }
}