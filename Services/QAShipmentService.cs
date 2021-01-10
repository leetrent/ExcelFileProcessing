using ExcelFileProcessing.Repositories;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelFileProcessing.Services
{
    public class QAShipmentService
    {
        private readonly IQAShipmentRepository _repository;

        public QAShipmentService(IQAShipmentRepository repo)
        {
            _repository = repo;
        }

        Task<int> ProcessExcelFile(IFormFile file)
        {
            return null;
        }
    }
}
