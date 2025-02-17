using Microsoft.AspNetCore.Mvc;
using OrderProcessingApp.Models;

namespace OrderProcessingApp.Controllers
{
    public class OrderController : Controller
    {
        [HttpGet]
        public IActionResult CreateOrder()
        {
            return View("CreateOrder");
        }

        [HttpPost]
        public IActionResult Submit(Order order)
        {
            if (order.OrderAmount <= 0 || (order.CustomerType != "New" && order.CustomerType != "Loyal"))
            {
                ModelState.AddModelError(string.Empty, "Invalid input.");
                return View("CreateOrder");
            }

            order.CalculateDiscount();
            return View("ResultOrder", order);
        }
    }
}
