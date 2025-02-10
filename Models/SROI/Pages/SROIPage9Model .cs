using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage9Model
    {
        public SROIPage9Model()
        {
        }

        public List<WELLBYTableRecord> WELLBYTableRecords { get; set; }
    }

    public class WELLBYTableRecord
    {
        public WELLBYTableRecord()
        {
        }

        public WELLBYTableRecord(string outcomeName, string unit, decimal effectSize, decimal grossValue, decimal valuePrOutcome, decimal totalWellby, decimal totalSocial, string source)
        {
            OutcomeName = outcomeName;
            Unit = unit;
            EffectSize = effectSize;
            GrossValue = grossValue;
            ValuePrOutcome = valuePrOutcome;
            TotalWellby = totalWellby;
            TotalSocial = totalSocial;
            Source = source;
        }

        public string OutcomeName { get; set; }
        public string Unit { get; set; }
        public decimal EffectSize { get; set; }
        public decimal GrossValue { get; set; }
        public decimal ValuePrOutcome { get; set; }
        public decimal TotalWellby { get; set; }
        public decimal TotalSocial { get; set; }
        public string Source { get; set; }
    }
}