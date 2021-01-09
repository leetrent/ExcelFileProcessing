using ExcelFileProcessing.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExcelFileProcessing.Repositories
{
    public interface IQAShipmentRepository
    {
        Task<int> Create(QAShipment model);
        Task<IList<QAShipment>> RetrieveAll();
    }
}
