using FitnessCenter.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Managers.RoomManager
{
    public class RoomManager : IRoomManager
    {
        private readonly CenterContext db;

        public RoomManager(CenterContext context)
        {
            db = context;
        }
        public async Task<Room> Add(Room room)
        {
            db.Rooms.Add(room);
            await db.SaveChangesAsync();
            return room;
        }

        public async Task DeleteById(int id)
        {
            var room = await this.GetById(id);
            db.Rooms.Remove(room);
            await db.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Room>> GetAll()
        {
            var collection = await db.Rooms.ToListAsync();
            return collection;
        }

        public async Task<Room> GetById(int id)
        {
            return await db.Rooms.FirstOrDefaultAsync(a => a.RoomId == id);
        }

        public async Task UpdateById(int id, Room room)
        {
            var room1 = await this.GetById(id);
            room1.Name = room.Name;
            room1.CenterId = room.CenterId;
            await db.SaveChangesAsync();
        }
    }
}
