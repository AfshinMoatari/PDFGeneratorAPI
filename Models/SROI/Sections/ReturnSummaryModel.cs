namespace Impactly_PDF_Generator.Models.SROI
{
    public class ReturnSummaryModel
    {
        public ReturnSummaryModel(decimal social, decimal budgetary, decimal socioEconomic)
        {
            Social = social;
            Budgetary = budgetary;
            SocioEconomic = socioEconomic;
        }

        public decimal Social { get; set; }
        public decimal Budgetary { get; set; }
        public decimal SocioEconomic { get; set; }
    }
}
