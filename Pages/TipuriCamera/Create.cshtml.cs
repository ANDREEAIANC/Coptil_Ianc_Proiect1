using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Coptil_Ianc_Proiect1.Pages.TipuriCamera
{
    [Authorize(Roles = "admin")]
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
        public TipCamera TipCamera { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.TipCamera == null || TipCamera == null)
            {
                return Page();
            }

            _context.TipCamera.Add(TipCamera);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
