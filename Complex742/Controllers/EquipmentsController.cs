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
        private IEquipmentRepository repository;
        public EquipmentsController(IEquipmentRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index()
        {
            return View(repository.EquipmentRepository);
        }
    }
}
