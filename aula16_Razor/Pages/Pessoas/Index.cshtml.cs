using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aula16_Razor.Data;
using aula16_Razor.Models;

namespace aula16_Razor.Pages.Pessoas
//namespace CadastroPessoas.Pages.Pessoas
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public List<Pessoa> Pessoas { get; set; }

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Pessoas = await _context.Pessoas.ToListAsync();
        }
    }
}
