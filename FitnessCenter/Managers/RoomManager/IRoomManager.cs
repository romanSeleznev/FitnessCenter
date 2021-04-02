using FitnessCenter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.RoomManager
{
    public interface IRoomManager
    {
        Task<IReadOnlyCollection<Room>> GetAll();
        Task<Room> Add(Room room);

        Task<Room> GetById(int id);

        Task UpdateById(int id, Room room);

        Task DeleteById(int id);
    }
}
