using Amazon.Runtime.Internal.Endpoints.StandardLibrary;
using Impactly_PDF_Generator.Models;
using Impactly_PDF_Generator.Models.Enums;
using Impactly_PDF_Generator.Models.SROI;
using Impactly_PDF_Generator.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Primitives;
using System.IO;

namespace Impactly_PDF_Generator.Controllers
{
    [ApiController]
    [Route("report")]
    public class SROIReportController : ControllerBase
    {
        private readonly ISROIPDFGeneratorService _SROIPDFGeneratorService;
        private readonly IPDFUploaderService _PDFUploaderService;

        public SROIReportController(
            ISROIPDFGeneratorService SROIPDFGeneratorService,
            IPDFUploaderService PDFUploaderService)
        {
            _SROIPDFGeneratorService = SROIPDFGeneratorService;
            _PDFUploaderService = PDFUploaderService;
        }

        [HttpPost("sroi")]
        public async Task<ActionResult<string>> GetSROIReport(
        [FromBody] SROIRequestModel requestModel
        )
        {
            requestModel.Language = LanguageEnum.Danish;
            var env = GetEnv(HttpContext.Request);

            var fileName = await _SROIPDFGeneratorService.CreatePDF(requestModel);
            if (fileName is not null)
            {
                await _PDFUploaderService.UploadPDFAsync(fileName, env);
            }

            return Ok(fileName);
        }

        private string GetEnv(HttpRequest request)
        {
            var headers = request.Headers;
            if (headers.TryGetValue("ENV", out StringValues env))
            {
                string headerValue = env.ToString();
                return headerValue;
            }
            new Exception("No eviroment found");
            return null;
        }
    }
}
