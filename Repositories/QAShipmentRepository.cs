using ExcelFileProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExcelFileProcessing.Data;

namespace ExcelFileProcessing.Repositories
{
    public class QAShipmentRepository : IQAShipmentRepository
    {
        private readonly ExcelFileProcessingContext _dbContext;

        public QAShipmentRepository(ExcelFileProcessingContext context)
        {
            _dbContext = context;
        }

        public async Task<int> Create(QAShipment model)
        {
            _dbContext.QAShipment.Add(model);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<IList<QAShipment>> RetrieveAll()
        {
            return  await _dbContext.QAShipment.ToListAsync();
        }
    }
}