using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcelFileProcessing.Models
{
    public class QAShipment
    {
        public string ID { get; set; }
        public string Type { get; set; }
        public string Matrix { get; set; }
        public string MatrixClass { get; set; }
        public string FilterLotNumber { get; set; }
        public string BufferLotNumber { get; set; }
        public string Agent { get; set; }
        public string Target { get; set; }
        public string StockId { get; set; }
        public string FinalSpikedConcentration { get; set; }
        public string QAClass { get; set; }
        public string PrepAnalyst { get; set; }
        public string PrepDate { get; set; }


    }
}
