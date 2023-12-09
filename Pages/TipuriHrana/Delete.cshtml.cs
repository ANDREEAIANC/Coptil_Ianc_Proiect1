using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Coptil_Ianc_Proiect1.Pages.TipuriHrana
{
    [Authorize(Roles = "admin")]
    public class DeleteModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public DeleteModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TipHrana TipHrana { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipHrana == null)
            {
                return NotFound();
            }

            var tiphrana = await _context.TipHrana.FirstOrDefaultAsync(m => m.TipHranaId == id);

            if (tiphrana == null)
            {
                return NotFound();
            }
            else 
            {
                TipHrana = tiphrana;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TipHrana == null)
            {
                return NotFound();
            }
            var tiphrana = await _context.TipHrana.FindAsync(id);

            if (tiphrana != null)
            {
                TipHrana = tiphrana;
                _context.TipHrana.Remove(TipHrana);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
