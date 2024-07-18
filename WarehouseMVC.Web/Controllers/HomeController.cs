using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarehouseMVC.Application.Interfaces;
using WarehouseMVC.Web.Models;

namespace WarehouseMVC.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUpgradeCostService _totalCost;


        public HomeController(ILogger<HomeController> logger, IUpgradeCostService totalCost)
        {
            _logger = logger;
            _totalCost = totalCost;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public IActionResult UpgradeSummary()
        {
            return View();
        }
    }
}
