using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ContosoCrafts.WebSite.Models;
using ContosoCrafts.WebSite.Services;

namespace ContosoCrafts.WebSite.Pages
{
    public class ProductModel : PageModel
    {
        public JsonFileProductService ProductService { get; set; }
        public Product[] Products { get; private set; }

        public ProductModel(JsonFileProductService jsonFileProductService)
        {
            this.ProductService = jsonFileProductService;
        }

        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
