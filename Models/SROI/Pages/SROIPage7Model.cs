using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage7Model
    {
        public SROIPage7Model() { }

        public List<BasicAlternativesTableRecord> BasicAlternativesTableRecords { get; set; }
    }

    public class BasicAlternativesTableRecord
    {
        public BasicAlternativesTableRecord()
        {
        }

        public BasicAlternativesTableRecord(string valueType, string outcomeName, decimal pCTAmount, decimal amount, string source, string comments)
        {
            ValueType = valueType;
            OutcomeName = outcomeName;
            PCTAmount = pCTAmount;
            Amount = amount;
            Source = source;
            Comments = comments;
        }

        public string ValueType { get; set; }
        public string OutcomeName { get; set; }
        public decimal PCTAmount { get; set; }
        public decimal Amount { get; set; }
        public string Source { get; set; }
        public string Comments { get; set; }
    }
}