using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using ContosoCrafts.WebSite.Models;
using Microsoft.AspNetCore.Hosting;

namespace ContosoCrafts.WebSite.Services
{
    public class JsonFileProductService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }

        public string JsonFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json");

        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            this.WebHostEnvironment = webHostEnvironment;
        }

        public Product[]? GetProducts()
        {
            using var jsonFileReader = File.OpenText(JsonFileName);
            var res = JsonSerializer.Deserialize<Product[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true});
            return res;
        }
    }
}