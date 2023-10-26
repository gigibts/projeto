using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
namespace projeto.Areas.Admin.Controllers

{
    public class AdminController : Controller
    {
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
        public IActionResult Index()
        {
        return View();
        }
    }
}