using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage6Model
    {
        public SROIPage6Model() { }

        public List<OutcomeTableRecord> OutcomeTableRecords { get; set; }
    }

    public class OutcomeTableRecord
    {
        public OutcomeTableRecord()
        {
        }

        public OutcomeTableRecord(string valueType, string outcomeName, int n, decimal results, string source, decimal answerRate, int duration, string significance)
        {
            ValueType = valueType;
            OutcomeName = outcomeName;
            this.n = n;
            Results = results;
            Source = source;
            AnswerRate = answerRate;
            Duration = duration;
            Significance = significance;
        }

        public string ValueType { get; set; }
        public string OutcomeName { get; set; }
        public int n { get; set; }
        public decimal Results { get; set; }
        public string Source { get; set; }
        public decimal AnswerRate { get; set; }
        public int Duration { get; set; }
        public string Significance { get; set; }
    }
}