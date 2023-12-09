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

namespace Coptil_Ianc_Proiect1.Pages.Programari
{
    [Authorize(Roles = "admin")]
    public class DetailsModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public DetailsModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

      public Programare Programare { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Programare == null)
            {
                return NotFound();
            }

            var programare = await _context.Programare.Include(p => p.TipHrana).Include(p => p.TipCamera).Include(p => p.TipServiciu).FirstOrDefaultAsync(m => m.ProgramareId == id);
            if (programare == null)
            {
                return NotFound();
            }
            else 
            {
                Programare = programare;
            }
            return Page();
        }
    }
}
