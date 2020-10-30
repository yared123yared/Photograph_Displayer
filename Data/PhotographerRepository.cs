using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class PhotographerRepository : IRepository<Photographer>
    {
        private readonly DataContext _context;
        public PhotographerRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteData(Photographer dept)
        {
            _context.Photographer.Remove(dept);
            _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Photographer>> GetData()
        {
            //    Getting database data here
            return await _context.Photographer.ToListAsync();
        }

        public async Task<Photographer> GetDataByEmail(string email)
        {
            return await _context.Photographer.FirstOrDefaultAsync(x => x.Email == email);
        }

        public async Task<Photographer> GetDataById(int id)
        {
            return await _context.Photographer.FirstOrDefaultAsync(x => x.PhotographerId == id);
        }

        public async Task<Photographer> UpdateData(Photographer dept)
        {
            _context.Photographer.Add(dept);
            await _context.SaveChangesAsync();
            return dept;
        }

        Task<List<Photographer>> IRepository<Photographer>.GetDataByEmail(string email)
        {
            throw new System.NotImplementedException();
        }
    }
}
