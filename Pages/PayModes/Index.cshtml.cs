using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SupermarketWeb.Data;
using SupermarketWeb.Models;

namespace SupermarketWeb.Pages.PayModes
{
    public class IndexModel : PageModel
    {
        private readonly SupermarketContext _context;

        public IndexModel(SupermarketContext context)
        {
            _context = context;
        }

        public IList<PayMode> PayModes { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.PayModes != null)
            {
                PayModes = await _context.PayModes.ToListAsync();
            }
        }
    }
}
