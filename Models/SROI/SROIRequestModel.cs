using Impactly_PDF_Generator.Models.Enums;
using Impactly_PDF_Generator.Models.SROI.Pages;

namespace Impactly_PDF_Generator.Models.SROI
{
    public class SROIRequestModel
    {
        public Guid Id { get; set; }
        public LanguageEnum Language { get; set; }
        public CurrencyEnum Currency { get; set; }

        public SROIPage1Model SROIPage1 { get; set; }
        public SROIPage2Model SROIPage2 { get; set; }
        public SROIPage3Model SROIPage3 { get; set; }
        public SROIPage4Model SROIPage4 { get; set; }
        public SROIPage5Model SROIPage5 { get; set; }
        public SROIPage6Model SROIPage6 { get; set; }
        public SROIPage7Model SROIPage7 { get; set; }
        public SROIPage8Model SROIPage8 { get; set; }
        public SROIPage9Model SROIPage9 { get; set; }
        public SROIPage10Model SROIPage10 { get; set; }
        public SROIPage11Model SROIPage11 { get; set; }
    }
}