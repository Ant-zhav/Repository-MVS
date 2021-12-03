using Complex742.Data;
using Complex742.Models.Equipments;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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
        public async Task<IActionResult> Index(Equipment eq=null)
        { 
            _logger.LogInformation("EquipmentsController.Index called {0}", eq.equipmentId);
            
           
            return View(await Task.Run(() => repository.list.Where(p => eq.equipmentId==0 ? p.masterEquipment==null : p.masterEquipment==eq).ToList()));
        }
        public async void Add(Equipment eq)
        {
            _logger.LogInformation("EquipmentsController Equipment added");
            await Task.Run(()=>repository.Add(eq));
        }
    }
}
