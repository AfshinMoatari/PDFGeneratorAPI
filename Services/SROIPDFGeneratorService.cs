using Microsoft.AspNetCore.Mvc.RazorPages;
using PuppeteerSharp;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using Impactly_PDF_Generator.Models.SROI;

namespace Impactly_PDF_Generator.Services
{
    public interface ISROIPDFGeneratorService
    {
        Task<string?> CreatePDF(SROIRequestModel SROIRequestModel);
    }

    public class SROIPDFGeneratorService : PageModel, ISROIPDFGeneratorService
    {
        private readonly IRendererService rendererService;

        public SROIPDFGeneratorService(IRendererService _rendererService)
        {
            rendererService = _rendererService;
        }
        public SROIRequestModel _SROIRequestModel { get; set; } = new();

        public async Task<string?> CreatePDF(SROIRequestModel SROIRequestModel)
        {
            _SROIRequestModel = SROIRequestModel;
            var reportName = $"#SROI#{SROIRequestModel.Id}";
            var baseDirectory = Directory.GetCurrentDirectory();
            var reportPage1HTML = await rendererService.RenderPartialToStringAsync($"SROIPage1_{SROIRequestModel.Language}", this);
            var reportPage2HTML = await rendererService.RenderPartialToStringAsync($"SROIPage2_{SROIRequestModel.Language}", this);
            var reportPage3HTML = await rendererService.RenderPartialToStringAsync($"SROIPage3_{SROIRequestModel.Language}", this);
            var reportPage4HTML = await rendererService.RenderPartialToStringAsync($"SROIPage4_{SROIRequestModel.Language}", this);
            var reportPage5HTML = await rendererService.RenderPartialToStringAsync($"SROIPage5_{SROIRequestModel.Language}", this);
            var reportPage6HTML = await rendererService.RenderPartialToStringAsync($"SROIPage6_{SROIRequestModel.Language}", this);
            var reportPage7HTML = await rendererService.RenderPartialToStringAsync($"SROIPage7_{SROIRequestModel.Language}", this);
            var reportPage8HTML = await rendererService.RenderPartialToStringAsync($"SROIPage8_{SROIRequestModel.Language}", this);
            var reportPage9HTML = await rendererService.RenderPartialToStringAsync($"SROIPage9_{SROIRequestModel.Language}", this);
            var reportPage10HTML = await rendererService.RenderPartialToStringAsync($"SROIPage10_{SROIRequestModel.Language}", this);
            var reportPage11HTML = await rendererService.RenderPartialToStringAsync($"SROIPage11_{SROIRequestModel.Language}", this);

            string tempDirectory = Path.Combine(baseDirectory, "Pod");
            var reportPage1OutputFile = Path.Combine(tempDirectory, $"{reportName}_p1.pdf");
            var reportPage2OutputFile = Path.Combine(tempDirectory, $"{reportName}_p2.pdf");
            var reportPage3OutputFile = Path.Combine(tempDirectory, $"{reportName}_p3.pdf");
            var reportPage4OutputFile = Path.Combine(tempDirectory, $"{reportName}_p4.pdf");
            var reportPage5OutputFile = Path.Combine(tempDirectory, $"{reportName}_p5.pdf");
            var reportPage6OutputFile = Path.Combine(tempDirectory, $"{reportName}_p6.pdf");
            var reportPage7OutputFile = Path.Combine(tempDirectory, $"{reportName}_p7.pdf");
            var reportPage8OutputFile = Path.Combine(tempDirectory, $"{reportName}_p8.pdf");
            var reportPage9OutputFile = Path.Combine(tempDirectory, $"{reportName}_p9.pdf");
            var reportPage10OutputFile = Path.Combine(tempDirectory, $"{reportName}_p10.pdf");
            var reportPage11OutputFile = Path.Combine(tempDirectory, $"{reportName}_p11.pdf");
            var outputFile = Path.Combine(tempDirectory, $"{reportName}.pdf");

            var portraiPDFOptions = new PdfOptions();
            portraiPDFOptions.Width = "880px";
            portraiPDFOptions.Height = "1280px";
            portraiPDFOptions.PrintBackground = true;

            var landscapePDFOptions = new PdfOptions();
            landscapePDFOptions.Width = "1280px";
            landscapePDFOptions.Height = "1280px";
            landscapePDFOptions.PageRanges = "1";
            landscapePDFOptions.PrintBackground = true;

            using (var browser = await Puppeteer.LaunchAsync(new LaunchOptions()
            {
                Headless = true,
                Args = new[] {
                  "--disable-gpu",
                  "--disable-dev-shm-usage",
                  "--disable-setuid-sandbox",
                  "--no-sandbox"}
            }))
            {
                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage1HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage1OutputFile, portraiPDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage2HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage2OutputFile, portraiPDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage3HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage3OutputFile, portraiPDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage4HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_page4.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage4OutputFile, portraiPDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage5HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage5OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage6HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage6OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage7HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage7OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage8HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage8OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage9HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage9OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage10HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage10OutputFile, landscapePDFOptions);
                }

                using (var page = await browser.NewPageAsync())
                {
                    await page.SetContentAsync(reportPage11HTML);
                    await page.AddStyleTagAsync(new AddTagOptions { Path = baseDirectory + "/Views/SROI/sroi_base.css" });
                    await page.EvaluateExpressionHandleAsync("document.fonts.ready");
                    await page.PdfAsync(reportPage11OutputFile, landscapePDFOptions);
                }
            }

            using (PdfDocument one = PdfReader.Open(reportPage1OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument two = PdfReader.Open(reportPage2OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument three = PdfReader.Open(reportPage3OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument four = PdfReader.Open(reportPage4OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument five = PdfReader.Open(reportPage5OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument six = PdfReader.Open(reportPage6OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument seven = PdfReader.Open(reportPage7OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument eight = PdfReader.Open(reportPage8OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument nine = PdfReader.Open(reportPage9OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument ten = PdfReader.Open(reportPage10OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument eleven = PdfReader.Open(reportPage11OutputFile, PdfDocumentOpenMode.Import))
            using (PdfDocument outPdf = new PdfDocument())
            {
                CopyPages(one, outPdf);
                CopyPages(two, outPdf);
                CopyPages(three, outPdf);
                CopyPages(four, outPdf);
                CopyPages(five, outPdf);
                CopyPages(six, outPdf);
                CopyPages(seven, outPdf);
                CopyPages(eight, outPdf);
                CopyPages(nine, outPdf);
                CopyPages(ten, outPdf);
                CopyPages(eleven, outPdf);
                outPdf.Save(outputFile);
            }

            void CopyPages(PdfDocument from, PdfDocument to)
            {
                for (int i = 0; i < from.PageCount; i++)
                {
                    to.AddPage(from.Pages[i]);
                }
            }

            if (Directory.GetFiles(tempDirectory, $"{reportName}.pdf").Length == 0)
            {
                reportName = null;
            }
            return reportName;
        }
    }
}
