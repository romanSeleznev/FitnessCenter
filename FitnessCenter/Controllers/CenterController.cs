using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FitnessCenter.Models;
using FitnessCenter.Managers.CenterManager;

namespace FitnessCenter.Controllers
{
    public class CenterController : Controller
    {
        private readonly ICenterManager Manager;
        public CenterController(ICenterManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> ShowCenter()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public async Task<ActionResult> DeleteCenter(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(ShowCenter));
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Center center)
        {
            await Manager.Add(center);
            return RedirectToAction(nameof(ShowCenter));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateCenter(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateCenter(int id, Center center)
        {
            await Manager.UpdateById(id, center);
            return RedirectToAction(nameof(ShowCenter));
        }
    }
}
