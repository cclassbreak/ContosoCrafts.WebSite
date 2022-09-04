using ContosoCrafts.WebSite.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ContosoCrafts.WebSite.Models;

namespace ContosoCrafts.WebSite.Controllers
{
    [Route("_api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public JsonFileProductService ProductService { get; set; }


        public ProductController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return ProductService.GetProducts();
        }

    }
}
