using DapperTest.BL.Interfaces;
using DapperTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DapperTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBL _userBL;

        public HomeController(ILogger<HomeController> logger, IUserBL userBL)
        {
            _logger = logger;
            _userBL = userBL;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(null);
        }

        [HttpPost]
        public IActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                int? userID = _userBL.Autentificate(model.Email, model.Password);
                if (userID != null)
                {
                    return View(_userBL.GetUserById(userID.Value));
                }
            }
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
    }
}