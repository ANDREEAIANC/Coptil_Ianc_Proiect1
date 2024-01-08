using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Coptil_Ianc_Proiect1.Data;
using Coptil_Ianc_Proiect1.Models;

namespace Coptil_Ianc_Proiect1.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public DetailsModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

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
    }
}
