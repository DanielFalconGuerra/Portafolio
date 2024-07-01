using Microsoft.AspNetCore.Mvc;
using Portafolio.Repositories;

namespace Portafolio.Controllers
{
    public class SportsAPIController : Controller
    {
        private readonly IApiFutbolRepository _apiFutbolRepository;
        public SportsAPIController(IApiFutbolRepository apiFutbolRepository)
        {
            _apiFutbolRepository = apiFutbolRepository;
        }
        public async Task<IActionResult> Index()
        {
            var response = await _apiFutbolRepository.getTotals();
            if(response == null)
            {
                return NotFound();
            }
            if(response.statusCode != 200)
            {
                return NotFound();
            }
            return View(response.total);
        }

    }
}
