using _04_MVC_Layout_Partial_ViewComp.Models;
using Microsoft.AspNetCore.Mvc;

namespace _04_MVC_Layout_Partial_ViewComp.ViewComponents
{
    public class Product : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Models.Product product = new Models.Product()
            {
                Id = 1,
                Name = "Telefon",
                Price = 20000
            };

            return View(product);
        }
        //public async Task<IViewComponentResult> InvokeAsync()
        //{
        //    return View();
        //}
    }
}
