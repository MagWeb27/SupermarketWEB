
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWeb.Models;
using SupermarketWeb.Data;
using Microsoft.EntityFrameworkCore;

using Microsoft.JSInterop;
using Microsoft.AspNetCore.Authorization;

namespace SupermarketWeb.Pages.Sales
{
    [Authorize]
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

        

        public class Sales
        {
            public List<Product> ProductList { get; set; }

            public Sales()
            {
                ProductList = new List<Product>();
            }

            [JSInvokable]
            public void AddProduct()
            {
                ProductList.Add(new Product());
            }
        }
    }
}
