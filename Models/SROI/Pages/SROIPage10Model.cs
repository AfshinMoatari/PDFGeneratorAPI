using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage10Model
    {
        public SROIPage10Model()
        {
        }

        public List<SensitivityAnalysisRecord> SensitivityAnalysisRecords { get; set; }
    }
    public class SensitivityAnalysisRecord
    {
        public SensitivityAnalysisRecord()
        {
        }

        public SensitivityAnalysisRecord(string valueType, string outcomeName, string beneficiary, decimal gross, decimal effectSize, decimal total, decimal deadWeight, decimal displacement, decimal attribution, decimal dropOff, decimal net)
        {
            ValueType = valueType;
            OutcomeName = outcomeName;
            Beneficiary = beneficiary;
            Gross = gross;
            EffectSize = effectSize;
            Total = total;
            DeadWeight = deadWeight;
            Displacement = displacement;
            Attribution = attribution;
            DropOff = dropOff;
            Net = net;
        }

        public string ValueType { get; set; }
        public string OutcomeName { get; set; }
        public string Beneficiary { get; set; }
        public decimal Gross { get; set; }
        public decimal EffectSize { get; set; }
        public decimal Total { get; set; }
        public decimal DeadWeight { get; set; }
        public decimal Displacement { get; set; }
        public decimal Attribution { get; set; }
        public decimal DropOff { get; set; }
        public decimal Net { get; set; }
    }
}