namespace Impactly_PDF_Generator.Models.SROI
{
    public class StakeholdersSummaryModel
    {
        public StakeholdersSummaryModel(string name, int amount, List<string> changes)
        {
            Name = name;
            Amount = amount;
            Changes = changes;
        }

        public string Name { get; set; }
        public int Amount { get; set; }
        public List<string> Changes { get; set; }
    }
}
