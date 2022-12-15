using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


//Esta clase es el controlador de la pagina razor "Consultas"
namespace PruebaTecnica2EvaDWS_IvanIglesiasSanchez.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly BdEvaluacionContext context;
        public ConsultasController(BdEvaluacionContext _context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index() { 
        
            var evaluacion = await context.EvaCatEvaluacions.ToListAsync();
            return View(evaluacion);
        }

        //Pagina no carga.
    }
}
