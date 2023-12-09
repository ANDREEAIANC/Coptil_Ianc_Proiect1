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
    public class IndexModel : PageModel
    {
        private readonly Coptil_Ianc_Proiect1.Data.AdapostContext _context;

        public IndexModel(Coptil_Ianc_Proiect1.Data.AdapostContext context)
        {
            _context = context;
        }

        public IList<Recenzie> Recenzie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Recenzie != null)
            {
                Recenzie = await _context.Recenzie.ToListAsync();
            }
        }
    }
}
