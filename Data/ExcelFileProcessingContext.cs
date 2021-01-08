using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExcelFileProcessing.Models;

namespace ExcelFileProcessing.Data
{
    public class ExcelFileProcessingContext : DbContext
    {
        public ExcelFileProcessingContext (DbContextOptions<ExcelFileProcessingContext> options)
            : base(options)
        {
        }

        public DbSet<ExcelFileProcessing.Models.QAShipment> QAShipment { get; set; }
    }
}
