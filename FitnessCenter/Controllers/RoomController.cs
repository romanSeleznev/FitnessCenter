using FitnessCenter.Managers.RoomManager;
using FitnessCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Controllers
{
    public class RoomController : Controller
    {
        private readonly IRoomManager Manager;

        public RoomController(IRoomManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> ShowRoom()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Room room)
        {
            await Manager.Add(room);
            return RedirectToAction(nameof(ShowRoom));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateRoom(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateRoom(int id, Room room)
        {
            await Manager.UpdateById(id, room);
            return RedirectToAction(nameof(ShowRoom));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteRoom(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(ShowRoom));
        }
    }
}
