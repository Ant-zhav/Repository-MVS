using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Complex742.Data;
using Complex742.Models.Equipments;

namespace Complex742.Controllers
{
    public class EquipmentsController : Controller
    {
        private readonly ILogger<EquipmentsController> _logger;

        private IRepository<Equipment> repository;
        public EquipmentsController(IRepository<Equipment> repo, ILogger<EquipmentsController> logger)
        {
            repository = repo;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            _logger.LogInformation("EquipmentsController.GetAll called");
            return View(await repository.GetAll());
        }
    }
}
