using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{

    public class SROIPage3Model
    {
        public SROIPage3Model() { }

        public List<OutcomeSummaryModel> OutcomeSummaries { get; set; }
    }

    public class OutcomeSummaryModel
    {
        public string ValueType { get; set; }

        public string OutcomeName { get; set; }
        public string OutcomeDescription { get; set; }
        public string BeneficiaryName { get; set; }
        public int PopulationSize { get; set; }
        public decimal EffectSize { get; set; }
        public decimal Benchmark { get; set; }
        public decimal EffectNumber { get; set; }
        public string EffectType { get; set; }
    }
}