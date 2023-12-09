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
    public class DetailsModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public DetailsModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

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
    }
}
