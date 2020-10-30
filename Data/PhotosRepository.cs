using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data
{
    public class PhotosRepository : IRepository<Photos>
    {
        private readonly DataContext _context;
        public PhotosRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<bool> DeleteData(Photos photos)
        {
            _context.Photos.Remove(photos);
            _context.SaveChangesAsync();
            return true;
        }



        public async Task<List<Photos>> GetData()
        {
            //    Getting database data here
            var model = await _context.Photos.ToListAsync();
            foreach (var photo in model)
            {
                if (photo.PhotographerEmail.Equals("yaredyaya16@gmail.com"))
                {
                    Console.WriteLine("yesss");
                }
            }


            Console.WriteLine(model);
            return model;

        }

        public async Task<Photos> GetDataByEmail(string email)
        {
            return await _context.Photos.FirstOrDefaultAsync(x => x.PhotographerEmail == email);
        }

        public async Task<Photos> GetDataById(int id)
        {
            return await _context.Photos.FirstOrDefaultAsync(x => x.PhotosId == id);
        }

        public async Task<Photos> UpdateData(Photos photos)
        {
            _context.Photos.Add(photos);
            await _context.SaveChangesAsync();
            return photos;
        }
    }
}
