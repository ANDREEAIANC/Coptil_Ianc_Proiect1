using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;

namespace Coptil_Ianc_Proiect1.Pages.TipuriServicii
{
    public class CreateModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public CreateModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TipServiciu TipServiciu { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.TipServiciu == null || TipServiciu == null)
            {
                return Page();
            }

            _context.TipServiciu.Add(TipServiciu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
