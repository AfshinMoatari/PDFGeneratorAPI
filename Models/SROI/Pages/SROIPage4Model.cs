using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage4Model
    {
        public SROIPage4Model(
            InputSummaryModel inputSummary, 
            WELLBYSummaryModel wELLBYSummaryModel, 
            SubjectiveWellbeingValuationSummaryModel subjectiveWellbeingValuationSummary,
            FinancialBudgetarySavingsSummaryModel financialBudgetarySavingsSummary, 
            ReturnSummaryModel reportSummary)
        {
            InputSummary = inputSummary;
            WELLBYSummaryModel = wELLBYSummaryModel;
            SubjectiveWellbeingValuationSummary = subjectiveWellbeingValuationSummary;
            FinancialBudgetarySavingsSummary = financialBudgetarySavingsSummary;
            ReportSummary = reportSummary;
        }

        public InputSummaryModel InputSummary { get; set; }
        public WELLBYSummaryModel WELLBYSummaryModel { get; set; }
        public SubjectiveWellbeingValuationSummaryModel SubjectiveWellbeingValuationSummary { get; set; }
        public FinancialBudgetarySavingsSummaryModel FinancialBudgetarySavingsSummary { get; set; }
        public ReturnSummaryModel ReportSummary { get; set; }
    }
}