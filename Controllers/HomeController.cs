using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
namespace Asp_net_Core_Project_with_Admin_Template_Setup
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}