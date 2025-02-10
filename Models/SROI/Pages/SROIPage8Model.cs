using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage8Model
    {
        public SROIPage8Model()
        {
        }

        public List<PricesTableRecord> PricesTableRecords { get; set; }
    }

    public class PricesTableRecord
    {
        public PricesTableRecord()
        {
        }

        public PricesTableRecord(string valueType, string outcomeName, string beneficiary, decimal grossValue, string source, string comments)
        {
            ValueType = valueType;
            OutcomeName = outcomeName;
            Beneficiary = beneficiary;
            GrossValue = grossValue;
            Source = source;
            Comments = comments;
        }

        public string ValueType { get; set; }
        public string OutcomeName { get; set; }
        public string Beneficiary { get; set; }
        public decimal GrossValue { get; set; }
        public string Source { get; set; }
        public string Comments { get; set; }
    }
}