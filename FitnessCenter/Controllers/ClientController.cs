using FitnessCenter.Managers.ClientManager;
using FitnessCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Controllers
{
    public class ClientController : Controller
    {
        private readonly IClientManager Manager;

        public ClientController(IClientManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> ShowClient()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Client client)
        {
            await Manager.Add(client);
            return RedirectToAction(nameof(ShowClient));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateClient(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateClient(int id, Client client)
        {
            await Manager.UpdateById(id, client);
            return RedirectToAction(nameof(ShowClient));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteClient(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(ShowClient));
        }
    }
}
