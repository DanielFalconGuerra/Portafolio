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
            var totals = await _apiFutbolRepository.getTotals();
            return View(totals);
        }

    }
}
