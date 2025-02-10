namespace Impactly_PDF_Generator.Models.SROI.Sections
{
    public class InputSummaryModel
    {
        public InputSummaryModel(decimal investmentAmount, int length, decimal totalCost, List<FundingSourceModel> fundingSources)
        {
            InvestmentAmount = investmentAmount;
            Length = length;
            TotalCost = totalCost;
            FundingSources = fundingSources;
        }

        public decimal InvestmentAmount { get; set; }
        public int Length { get; set; }
        public decimal TotalCost { get; set; }
        public List<FundingSourceModel> FundingSources { get; set; }

        public string GetFundingSourceString()
        {
            return string.Join(" ", FundingSources.Select(fs => $"{fs.Name} ({fs.Value}%)"));
        }
    }

    public class FundingSourceModel
    {
        public FundingSourceModel(string name, decimal value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}
