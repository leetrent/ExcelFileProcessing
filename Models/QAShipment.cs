using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelFileProcessing.Models
{
    public class QAShipment
    {
        public string ID { get; set; }
       // public string SampleNumber { get; set; }
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("QAShipment = {");

            //sb.Append("SampleNumber: ");
            //sb.Append(this.SampleNumber);
            sb.Append(", Type: ");
            sb.Append(this.Type);
            sb.Append(", Matrix: ");
            sb.Append(this.Matrix);
            sb.Append(", MatrixClass: ");
            sb.Append(this.MatrixClass);
            sb.Append(", FilterLotNumber: ");
            sb.Append(this.FilterLotNumber);
            sb.Append(", BufferLotNumber: ");
            sb.Append(this.BufferLotNumber);
            sb.Append(", Agent: ");
            sb.Append(this.Agent);
            sb.Append(", Target: ");
            sb.Append(this.Target);
            sb.Append(", StockId: ");
            sb.Append(this.StockId);
            sb.Append(", FinalSpikedConcentration: ");
            sb.Append(this.FinalSpikedConcentration);
            sb.Append(", QAClass: ");
            sb.Append(this.QAClass);
            sb.Append(", PrepAnalyst: ");
            sb.Append(this.PrepAnalyst);
            sb.Append(", PrepDate: ");
            sb.Append(this.PrepDate);
            sb.Append("}");


            return sb.ToString();
        }


    }
}
