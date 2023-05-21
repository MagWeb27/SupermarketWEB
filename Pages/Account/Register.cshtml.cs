using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SupermarketWeb.Data;
using SupermarketWeb.Models;

namespace SupermarketWeb.Pages.Account
{
    public class RegisterModel : PageModel
    {
        private readonly SupermarketContext _context;

        public RegisterModel(SupermarketContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid || _context.Users == null || User == null)
            {
                return Page();
            }

            _context.Users.Add(User);
            await _context.SaveChangesAsync();
            return RedirectToPage("../Index");
        }
    }
}
