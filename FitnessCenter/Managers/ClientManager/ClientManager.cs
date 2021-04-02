using FitnessCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.ClientManager
{
    public class ClientManager : IClientManager
    {
        private readonly CenterContext db;

        public ClientManager(CenterContext context)
        {
            db = context;
        }
        public async Task<Client> Add(Client client)
        {
            db.Clients.Add(client);
            await db.SaveChangesAsync();
            return client;
        }

        public async Task DeleteById(int id)
        {
            var client = await this.GetById(id);
            db.Clients.Remove(client);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Client>> GetAll()
        {
            var collection = await db.Clients.ToListAsync();
            return collection;
        }

        public async Task<Client> GetById(int id)
        {
            return await db.Clients.FirstOrDefaultAsync(a => a.ClientId == id);
        }

        public async Task UpdateById(int id, Client client)
        {
            var client1 = await this.GetById(id);
            client1.FirstName = client.FirstName;
            client1.LastName = client.LastName;
            client1.Age = client.Age;
            client1.PhoneNumber = client.PhoneNumber;
            client1.CenterId = client.CenterId;
            await db.SaveChangesAsync();
        }
    }
}
