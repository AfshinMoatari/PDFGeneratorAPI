using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage1Model
    {
        public SROIPage1Model(
            string reportName,
            string executiveSummary,
            string? logo,
            ReturnSummaryModel reportSummary)
        {
            ReportName = reportName;
            ExecutiveSummary = executiveSummary;
            Logo = logo;
            ReportSummary = reportSummary;
        }

        public string ReportName { get; set; }
        public string ExecutiveSummary { get; set; }
        public string? Logo { get; set; }
        public ReturnSummaryModel ReportSummary { get; set; }
    }
}