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
            return model;

        }










        public async Task<List<Photos>> GetPhotosByEmail(string email)
        {
            var model = await _context.Photos.ToListAsync();
            List<Photos> filteredPhotos = new List<Photos>();
            foreach (var photo in model)
            {

                if (photo.PhotographerEmail.Equals(email))
                {
                    filteredPhotos.Add(photo);
                }
            }
            return filteredPhotos;
        }

        public Task<Photos> GetDataByEmail(string email)
        {
            throw new NotImplementedException();
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

        public Task<List<Photos>> GetLoggedInUsers()
        {
            throw new NotImplementedException();
        }

        public Task<Photos> InsertLoggedInUser(Photos student)
        {
            throw new NotImplementedException();
        }
    }
}
