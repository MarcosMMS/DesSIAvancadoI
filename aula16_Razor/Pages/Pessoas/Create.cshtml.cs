using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using aula16_Razor.Data;
using aula16_Razor.Models;

namespace aula16_Razor.Pages.Pessoas
//namespace CadastroPessoas.Pages.Pessoas
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        [BindProperty]
        public Pessoa Pessoa { get; set; }

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Pessoas.Add(Pessoa);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
