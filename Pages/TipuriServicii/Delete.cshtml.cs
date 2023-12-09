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

namespace Coptil_Ianc_Proiect1.Pages.TipuriServicii
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
      public TipServiciu TipServiciu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipServiciu == null)
            {
                return NotFound();
            }

            var tipserviciu = await _context.TipServiciu.FirstOrDefaultAsync(m => m.TipServiciuId == id);

            if (tipserviciu == null)
            {
                return NotFound();
            }
            else 
            {
                TipServiciu = tipserviciu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TipServiciu == null)
            {
                return NotFound();
            }
            var tipserviciu = await _context.TipServiciu.FindAsync(id);

            if (tipserviciu != null)
            {
                TipServiciu = tipserviciu;
                _context.TipServiciu.Remove(TipServiciu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
