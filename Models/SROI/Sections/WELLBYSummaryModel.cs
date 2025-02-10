namespace Impactly_PDF_Generator.Models.SROI.Sections
{
    public class WELLBYSummaryModel
    {
        public WELLBYSummaryModel(decimal pointTotal, decimal pointPerParticipant, decimal costPerPoint)
        {
            PointTotal = pointTotal;
            PointPerParticipant = pointPerParticipant;
            CostPerPoint = costPerPoint;
        }

        public decimal PointTotal { get; set; }
        public decimal PointPerParticipant { get; set; }
        public decimal CostPerPoint { get; set; }
    }
}
