using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MueniCrafts.Services;
using MueniCrafts.Models;
namespace MueniCrafts.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductFile ProductFile { get; }

        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger, 
            JsonFileProductFile productFile)
        {
            _logger = logger;
            ProductFile = productFile;
        }

        public void OnGet()
        {
            Products = ProductFile.GetProducts();
        }
    }
}
