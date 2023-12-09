using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;

namespace Coptil_Ianc_Proiect1.Pages.Programari
{
    public class CreateModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;
        public List<SelectListItem> OptiuniSexPisica { get; set; }

        public CreateModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            ViewData["TipCameraId"] = new SelectList(_context.TipCamera, "TipCameraId", "Denumire");
            ViewData["TipHranaId"] = new SelectList(_context.TipHrana, "TipHranaId", "Denumire");
            ViewData["TipServiciuId"] = new SelectList(_context.Set<TipServiciu>(), "TipServiciuId", "Denumire");

            OptiuniSexPisica = new List<SelectListItem>
            {
                new SelectListItem { Text = "M", Value = "M" },
                new SelectListItem { Text = "F", Value = "F" }
            };
            return Page();
        }

        [BindProperty]
        public Programare Programare { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Programare == null || Programare == null)
            {
                return Page();
            }

            _context.Programare.Add(Programare);
            await _context.SaveChangesAsync();

            return RedirectToPage("/Index");
        }
    }
}
