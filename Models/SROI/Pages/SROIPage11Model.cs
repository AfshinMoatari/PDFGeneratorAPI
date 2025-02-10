using Impactly_PDF_Generator.Models.SROI.Sections;

namespace Impactly_PDF_Generator.Models.SROI.Pages
{
    public class SROIPage11Model
    {
        public SROIPage11Model() { }

        public List<AdditionalCommentsRecord> AdditionalCommentsRecords { get; set; }
    }

    public class AdditionalCommentsRecord
    {
        public AdditionalCommentsRecord()
        {
        }

        public AdditionalCommentsRecord(string valueType, string outcomeName, string beneficiary, string outcomeComments, string sensitivityComments)
        {
            ValueType = valueType;
            OutcomeName = outcomeName;
            Beneficiary = beneficiary;
            OutcomeComments = outcomeComments;
            SensitivityComments = sensitivityComments;
        }

        public string ValueType { get; set; }
        public string OutcomeName { get; set; }
        public string Beneficiary { get; set; }
        public string OutcomeComments { get; set; }
        public string SensitivityComments { get; set; }
    }
}