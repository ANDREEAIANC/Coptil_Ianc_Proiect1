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

namespace Coptil_Ianc_Proiect1.Pages.Camere
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
      public Camera Camera { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Camera == null)
            {
                return NotFound();
            }

            var camera = await _context.Camera.FirstOrDefaultAsync(m => m.CameraId == id);

            if (camera == null)
            {
                return NotFound();
            }
            else 
            {
                Camera = camera;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Camera == null)
            {
                return NotFound();
            }
            var camera = await _context.Camera.FindAsync(id);

            if (camera != null)
            {
                Camera = camera;
                _context.Camera.Remove(Camera);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
