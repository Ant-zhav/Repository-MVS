using Complex742.Data;
using Complex742.Models.Equipments;
using Microsoft.AspNetCore.Mvc;

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
            _logger.LogInformation("EquipmentsController.Index called");
            return View(await Task.Run(() => repository.list));
        }

        public void Create(Equipment equippment)
        { 
            repository.list.Add(equippment);
            
        }
        
    }
}
