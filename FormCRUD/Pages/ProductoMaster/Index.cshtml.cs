using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FormCRUD.DAL;
using FormCRUD.Models;

namespace FormCRUD.Pages.ProductoMaster
{
    public class IndexModel : PageModel
    {
        private readonly FormCRUD.DAL.AppDbContext _context;

        public IndexModel(FormCRUD.DAL.AppDbContext context)
        {
            _context = context;
        }

        public IList<Producto> Producto { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Producto = await _context.Products.ToListAsync();
        }
    }
}
