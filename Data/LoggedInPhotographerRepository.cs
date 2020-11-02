using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class LoggedInPhotographerRepository : IRepository<LoggedInPhotographer>
    {
        private readonly DataContext _context;
        public LoggedInPhotographerRepository(DataContext context)
        {
            _context = context;
        }

        public Task<bool> DeleteData(LoggedInPhotographer student)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<LoggedInPhotographer>> GetData()
        {
            throw new System.NotImplementedException();
        }

        public Task<LoggedInPhotographer> GetDataByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Task<LoggedInPhotographer> GetDataById(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<LoggedInPhotographer>> GetLoggedInUsers()
        {
            return await _context.LoggedInPhotographer.ToListAsync();
        }

        public Task<List<LoggedInPhotographer>> GetPhotosByEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public async Task<LoggedInPhotographer> InsertLoggedInUser(LoggedInPhotographer photographer)
        {
            _context.LoggedInPhotographer.Add(photographer);
            await _context.SaveChangesAsync();
            return photographer;
        }

        public Task<LoggedInPhotographer> UpdateData(LoggedInPhotographer student)
        {
            throw new System.NotImplementedException();
        }
    }
}


