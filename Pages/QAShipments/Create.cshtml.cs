using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExcelFileProcessing.Data;
using ExcelFileProcessing.Models;
using ExcelFileProcessing.Repositories;

namespace ExcelFileProcessing.Pages.QAShipments
{
    public class CreateModel : PageModel
    {
        private readonly IQAShipmentRepository _repository;

        public CreateModel(IQAShipmentRepository repo)
        {
            _repository = repo;
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

            await _repository.Create(QAShipment);

            return RedirectToPage("./Index");
        }
    }
}
