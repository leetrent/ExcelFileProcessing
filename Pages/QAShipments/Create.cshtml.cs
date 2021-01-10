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
using Microsoft.AspNetCore.Http;
using System.IO;
using OfficeOpenXml;

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
        public IFormFile UploadFile { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            var modelList = new List<QAShipment>();
            using (var stream = new MemoryStream())
            {
                await UploadFile.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;
                    Console.WriteLine($"[CreateModel][OnPostAsync] => (rowCount): {rowCount}");
                    for ( int row = 2; row <= rowCount; row++)
                    {
                        QAShipment model = new QAShipment();

                        //model.SampleNumber              = worksheet.Cells[row,  1].Value.ToString().Trim();
                        model.ID                        = Guid.NewGuid().ToString();
                        model.Type                      = worksheet.Cells[row,  2].Value.ToString().Trim();
                        model.Matrix                    = worksheet.Cells[row,  3].Value.ToString().Trim();
                        model.MatrixClass               = worksheet.Cells[row,  4].Value.ToString().Trim();
                        model.FilterLotNumber           = worksheet.Cells[row,  5].Value.ToString().Trim();
                        model.BufferLotNumber           = worksheet.Cells[row,  6].Value.ToString().Trim();
                        model.Agent                     = worksheet.Cells[row,  7].Value.ToString().Trim();
                        model.Target                    = worksheet.Cells[row,  8].Value.ToString().Trim();
                        model.StockId                   = worksheet.Cells[row,  9].Value.ToString().Trim();
                        model.FinalSpikedConcentration  = worksheet.Cells[row, 10].Value.ToString().Trim();
                        model.QAClass                   = worksheet.Cells[row, 11].Value.ToString().Trim();
                        model.PrepAnalyst               = worksheet.Cells[row, 12].Value.ToString().Trim();
                        model.PrepDate                  = worksheet.Cells[row, 13].Value.ToString().Trim();

                        modelList.Add(model);
                    }
                }
            }

            foreach ( var model in modelList)
            {
                //Console.WriteLine(model);
                await _repository.Create(model);
            }

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            //await _repository.Create(QAShipment);

            return RedirectToPage("./Index");
        }
    }
}
