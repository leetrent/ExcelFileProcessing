using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ExcelFileProcessing.Models;
using ExcelFileProcessing.Repositories;

namespace ExcelFileProcessing.Pages.QAShipments
{
    public class IndexModel : PageModel
    {
        private readonly IQAShipmentRepository _repository;

        public IndexModel(IQAShipmentRepository repo)
        {
            _repository = repo;
        }

        public IList<QAShipment> QAShipment { get;set; }

        public async Task OnGetAsync()
        {
            QAShipment = await _repository.RetrieveAll();
        }
    }
}
