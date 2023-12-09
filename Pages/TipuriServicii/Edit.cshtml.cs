using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Coptil_Ianc_Proiect1.Pages.TipuriServicii
{
    [Authorize(Roles = "admin")]
    public class EditModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public EditModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
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

            var tipserviciu =  await _context.TipServiciu.FirstOrDefaultAsync(m => m.TipServiciuId == id);
            if (tipserviciu == null)
            {
                return NotFound();
            }
            TipServiciu = tipserviciu;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TipServiciu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TipServiciuExists(TipServiciu.TipServiciuId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TipServiciuExists(int id)
        {
          return (_context.TipServiciu?.Any(e => e.TipServiciuId == id)).GetValueOrDefault();
        }
    }
}
