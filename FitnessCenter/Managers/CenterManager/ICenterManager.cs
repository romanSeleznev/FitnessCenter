using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.CenterManager
{
    public interface ICenterManager
    {
        Task<IReadOnlyCollection<Center>> GetAll();
        Task<Center> Add(Center center);

        Task<Center> GetById(int id);

        Task UpdateById(int id, Center center);

        Task DeleteById(int id);
    }
}
