using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.Drawing;
using WebApp.Application.Interfaces.Repositories;
using WebApp.Models.Pet;

namespace WebApp.Controllers
{
    public class PetController (IPetRepository _petRepository) : Controller
    {
        // GET: PetController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PetController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PetController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PetController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterPetVM petVM)
        {
            // @todo:-
            // 1- add validation to the model
            // 2- replace the manual mapping with automapper

            var pet = new Pet() {
                Name = petVM.Name,
                SpeciesId = petVM.SpeciesId,
                BreedId = petVM.BreedId,
                DateOfBirth = petVM.DateOfBirth,
                Gender = petVM.Gender,
                Color = petVM.Color,
                Size = petVM.Size,
                HealthStatus = petVM.HealthStatus,
                Vaccinated = petVM.Vaccinated,
                NeuteredStatus = petVM.NeuteredStatus,
                Description = petVM.Description,
                OwnerProfileId = petVM.OwnerProfileId
            };

            _petRepository.CreatePetAsync(pet);

            return View(pet);
        }

        // GET: PetController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PetController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PetController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PetController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
