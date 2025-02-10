namespace Impactly_PDF_Generator.Models.SROI.Sections
{
    public class SubjectiveWellbeingValuationSummaryModel
    {
        public SubjectiveWellbeingValuationSummaryModel(
            decimal totalSocialValue, 
            Dictionary<string, decimal> valueCategories, 
            Dictionary<string, decimal> beneficiaries)
        {
            TotalSocialValue = totalSocialValue;
            ValueCategories = valueCategories;
            Beneficiaries = beneficiaries;
        }

        public decimal TotalSocialValue { get; set; }
        public Dictionary<string, decimal> ValueCategories { get; set; }
        public Dictionary<string, decimal> Beneficiaries { get; set; }
    }
}
