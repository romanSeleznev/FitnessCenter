using FitnessCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.TrenerManager
{
    public class TrenerManager : ITrenerManager
    {
        private readonly CenterContext db;

        public TrenerManager(CenterContext context)
        {
            db = context;
        }
        public async Task<Trener> Add(Trener trener)
        {
            db.Treners.Add(trener);
            await db.SaveChangesAsync();
            return trener;
        }

        public async Task DeleteById(int id)
        {
            var trener= await this.GetById(id);
            db.Treners.Remove(trener);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Trener>> GetAll()
        {
            var collection = await db.Treners.ToListAsync();
            return collection;
        }

        public async Task<Trener> GetById(int id)
        {
            return await db.Treners.FirstOrDefaultAsync(a => a.TrenerId == id);
        }

        public async Task UpdateById(int id, Trener trener)
        {
            var NewTrener = await this.GetById(id);
            NewTrener.FirstName = trener.FirstName;
            NewTrener.LastName = trener.LastName;
            NewTrener.Adress = trener.Adress;
            NewTrener.CenterId = trener.CenterId;
            await db.SaveChangesAsync();
        }
    }
}
