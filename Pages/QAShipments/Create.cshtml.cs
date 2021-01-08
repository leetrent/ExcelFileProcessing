using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExcelFileProcessing.Data;
using ExcelFileProcessing.Models;

namespace ExcelFileProcessing.Pages.QAShipments
{
    public class CreateModel : PageModel
    {
        private readonly ExcelFileProcessing.Data.ExcelFileProcessingContext _context;

        public CreateModel(ExcelFileProcessing.Data.ExcelFileProcessingContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public QAShipment QAShipment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.QAShipment.Add(QAShipment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
