using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWeb.Models;
using SupermarketWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.Identity.Client;
using System.Reflection.Metadata.Ecma335;

namespace SupermarketWeb.Pages.Sales
{
    public class SalesModel : PageModel
    {
        private readonly SupermarketContext _context;

        public SalesModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<Product> Products { get; set; }
        
        public async Task OnGetAsync(string searchString)
        {


            
            var products = from p in _context.Products
                           select p;

            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString));
            }

            Products = await products.ToListAsync();

            
        }
    }
}
