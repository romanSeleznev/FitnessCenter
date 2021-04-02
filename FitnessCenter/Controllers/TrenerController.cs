using FitnessCenter.Managers.TrenerManager;
using FitnessCenter.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FitnessCenter.Controllers
{
    public class TrenerController : Controller
    {
        private readonly ITrenerManager Manager;

        public TrenerController(ITrenerManager manager)
        {
            Manager = manager;
        }
        public async Task<IActionResult> ShowTrener()
        {
            return View(await Manager.GetAll());
        }
        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Trener trener)
        {
            await Manager.Add(trener);
            return RedirectToAction(nameof(ShowTrener));
        }
        [HttpGet]
        public async Task<ViewResult> UpdateTrener(int id)
        {
            return View(await Manager.GetById(id));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateTrener(int id, Trener trener)
        {
            await Manager.UpdateById(id, trener);
            return RedirectToAction(nameof(ShowTrener));
        }
        [HttpGet]
        public async Task<ActionResult> DeleteTrener(int id)
        {
            await Manager.DeleteById(id);
            return RedirectToAction(nameof(ShowTrener));
        }
    }
}
