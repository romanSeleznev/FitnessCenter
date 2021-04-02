using FitnessCenter.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.CenterManager
{
    public class CenterManager : ICenterManager
    {
        
        private readonly CenterContext db;

        public CenterManager(CenterContext context)
        {
            db = context;
        }
        public async Task<Center> Add(Center center)
        {
            db.Centers.Add(center);
            await db.SaveChangesAsync();
            return center;
        }

        public async Task DeleteById(int id)
        {
            var center = await this.GetById(id);
            db.Centers.Remove(center);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Center>> GetAll()
        {
            var collection = await db.Centers.ToListAsync();
            return collection;
        }

        public async Task<Center> GetById(int id)
        {
            return await db.Centers.FirstOrDefaultAsync(a => a.CenterId == id);
        }

        public async Task UpdateById(int id, Center center)
        {
            var NewCenter = await this.GetById(id);
            NewCenter.Name = center.Name;
            NewCenter.Adress = center.Adress;
            NewCenter.PhoneNumber = center.PhoneNumber;
            await db.SaveChangesAsync();
        }
    }
}
