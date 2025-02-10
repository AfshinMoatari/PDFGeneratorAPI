namespace Impactly_PDF_Generator.Models.SROI.Sections
{
    public class FinancialBudgetarySavingsSummaryModel
    {
        public FinancialBudgetarySavingsSummaryModel(
            decimal totalBudgetaryValue, 
            Dictionary<string, decimal> valueCategories, 
            Dictionary<string, decimal> beneficiaries)
        {
            TotalBudgetaryValue = totalBudgetaryValue;
            ValueCategories = valueCategories;
            Beneficiaries = beneficiaries;
        }

        public decimal TotalBudgetaryValue { get; set; }
        public Dictionary<string, decimal> ValueCategories { get; set; }
        public Dictionary<string, decimal> Beneficiaries { get; set; }
    }
}
