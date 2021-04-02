using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.ClientManager
{
    public interface IClientManager
    {
        Task<IReadOnlyCollection<Client>> GetAll();
        Task<Client> Add(Client client);

        Task<Client> GetById(int id);

        Task UpdateById(int id, Client client);

        Task DeleteById(int id);
    }
}
