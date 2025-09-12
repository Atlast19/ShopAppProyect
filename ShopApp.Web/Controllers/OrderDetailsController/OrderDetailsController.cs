using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.Application.Interface.OrderDetails;

namespace ShopApp.Web.Controllers.OrderDetailsController
{
    public class OrderDetailsController : Controller
    {
        private readonly IOrderDetailsService orderDetailsService;

        public OrderDetailsController(IOrderDetailsService orderDetailsService)
        {
            this.orderDetailsService = orderDetailsService;
        }
        // GET: OrderDetailsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: OrderDetailsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: OrderDetailsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OrderDetailsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OrderDetailsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OrderDetailsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OrderDetailsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
