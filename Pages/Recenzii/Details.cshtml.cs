using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;

namespace Coptil_Ianc_Proiect1.Pages.Recenzii
{
    public class DetailsModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public DetailsModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

      public Recenzie Recenzie { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Recenzie == null)
            {
                return NotFound();
            }

            var recenzie = await _context.Recenzie.FirstOrDefaultAsync(m => m.RecenzieId == id);
            if (recenzie == null)
            {
                return NotFound();
            }
            else 
            {
                Recenzie = recenzie;
            }
            return Page();
        }
    }
}
