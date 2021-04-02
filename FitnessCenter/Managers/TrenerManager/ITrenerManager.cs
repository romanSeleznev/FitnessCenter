using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.TrenerManager
{
    public interface ITrenerManager
    {
        Task<IReadOnlyCollection<Trener>> GetAll();
        Task<Trener> Add(Trener trener);

        Task<Trener> GetById(int id);

        Task UpdateById(int id, Trener trener);

        Task DeleteById(int id);
    }
}
