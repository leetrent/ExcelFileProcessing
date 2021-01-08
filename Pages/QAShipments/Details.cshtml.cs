using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExcelFileProcessing.Data;
using ExcelFileProcessing.Models;

namespace ExcelFileProcessing.Pages.QAShipments
{
    public class DetailsModel : PageModel
    {
        private readonly ExcelFileProcessing.Data.ExcelFileProcessingContext _context;

        public DetailsModel(ExcelFileProcessing.Data.ExcelFileProcessingContext context)
        {
            _context = context;
        }

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
    }
}
