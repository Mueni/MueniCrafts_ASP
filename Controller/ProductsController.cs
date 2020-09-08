using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MueniCrafts.Models;
using MueniCrafts.Services;

namespace MueniCrafts.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductFile productFile)
        {
            this.ProductFile = productFile;
        }

        public JsonFileProductFile ProductFile { get; }

        [HttpGet]

        public IEnumerable<Product> Get()
        {
            return ProductFile.GetProducts();
        }
    }
}
