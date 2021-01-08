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
    public class IndexModel : PageModel
    {
        private readonly ExcelFileProcessing.Data.ExcelFileProcessingContext _context;

        public IndexModel(ExcelFileProcessing.Data.ExcelFileProcessingContext context)
        {
            _context = context;
        }

        public IList<QAShipment> QAShipment { get;set; }

        public async Task OnGetAsync()
        {
            QAShipment = await _context.QAShipment.ToListAsync();
        }
    }
}
