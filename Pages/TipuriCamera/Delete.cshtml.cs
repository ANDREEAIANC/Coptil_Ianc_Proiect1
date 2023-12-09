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

namespace Coptil_Ianc_Proiect1.Pages.TipuriCamera
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
      public TipCamera TipCamera { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TipCamera == null)
            {
                return NotFound();
            }

            var tipcamera = await _context.TipCamera.FirstOrDefaultAsync(m => m.TipCameraId == id);

            if (tipcamera == null)
            {
                return NotFound();
            }
            else 
            {
                TipCamera = tipcamera;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.TipCamera == null)
            {
                return NotFound();
            }
            var tipcamera = await _context.TipCamera.FindAsync(id);

            if (tipcamera != null)
            {
                TipCamera = tipcamera;
                _context.TipCamera.Remove(TipCamera);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
