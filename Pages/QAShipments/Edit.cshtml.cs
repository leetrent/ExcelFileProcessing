using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExcelFileProcessing.Data;
using ExcelFileProcessing.Models;

namespace ExcelFileProcessing.Pages.QAShipments
{
    public class EditModel : PageModel
    {
        private readonly ExcelFileProcessing.Data.ExcelFileProcessingContext _context;

        public EditModel(ExcelFileProcessing.Data.ExcelFileProcessingContext context)
        {
            _context = context;
        }

        [BindProperty]
        public QAShipment QAShipment { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            QAShipment = await _context.QAShipment.FirstOrDefaultAsync(m => m.ID == id);

            if (QAShipment == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(QAShipment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QAShipmentExists(QAShipment.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool QAShipmentExists(string id)
        {
            return _context.QAShipment.Any(e => e.ID == id);
        }
    }
}
