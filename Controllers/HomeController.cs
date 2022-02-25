using Microsoft.AspNetCore.Mvc;
using MvcApiCall.Models;

namespace MvcApiCall.Controllers
{
  public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allPlans= MealPlan.GetMealPlanDatas(EnvironmentVariables.apiKey);
            return View(allPlans);
        }

        public IActionResult Resources()
        {
            return View();
        }
    }
}