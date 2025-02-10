
namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage2Model
    {
        public SROIPage2Model(string interventionDescription, string interventionVision, List<string> interventionActivities, decimal inteventionCosts, int interventionParticipants, string targetGroupCategory, int targetGroupAgeMax, int targetGroupAgeMin, string targetGroupDescription, string targetGroupRiskFactors, List<StakeholdersSummaryModel> stakeholders)
        {
            InterventionDescription = interventionDescription;
            InterventionVision = interventionVision;
            InterventionActivities = interventionActivities;
            InterventionCosts = inteventionCosts;
            InterventionParticipants = interventionParticipants;
            TargetGroupCategory = targetGroupCategory;
            TargetGroupAgeMax = targetGroupAgeMax;
            TargetGroupAgeMin = targetGroupAgeMin;
            TargetGroupDescription = targetGroupDescription;
            TargetGroupRiskFactors = targetGroupRiskFactors;
            Stakeholders = stakeholders;
        }

        public string InterventionDescription { get; set; }
        public string InterventionVision { get; set; }
        public List<string> InterventionActivities { get; set; }
        public decimal InterventionCosts { get; set; }
        public int InterventionParticipants { get; set; }
        public string TargetGroupCategory { get; set; }
        public int TargetGroupAgeMax { get; set; }
        public int TargetGroupAgeMin { get; set; }
        public string TargetGroupDescription { get; set; }
        public string TargetGroupRiskFactors { get; set; }
        public List<StakeholdersSummaryModel> Stakeholders { get; set; }
    }
}