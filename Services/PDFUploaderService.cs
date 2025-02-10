using Amazon.S3;
using Amazon.S3.Model;

namespace Impactly_PDF_Generator.Services
{
    public interface IPDFUploaderService
    {
        Task UploadPDFAsync(string fileName, string env);
    }

    public class PDFUploaderService : IPDFUploaderService
    {
        private readonly IAmazonS3 _s3Client;

        public PDFUploaderService(IAmazonS3 s3Client)
        {
            _s3Client = s3Client;
        }

        public async Task UploadPDFAsync(string fileName, string env)
        {
            var s3Bucket = GetBucketName(env);
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "Pod");
            var filePath = Path.Combine(folderPath, $"{fileName}.pdf");
            FileInfo file = new FileInfo(filePath);

            PutObjectRequest request = new PutObjectRequest()
            {
                InputStream = file.OpenRead(),
                BucketName = s3Bucket,
                Key = file.Name
            };
            request.Metadata.Add("Content-Type", "application/pdf");
            var response = await _s3Client.PutObjectAsync(request);
            if (response.HttpStatusCode.Equals(System.Net.HttpStatusCode.OK))
            {
                DisposeTempFiles(fileName);
            }
        }

        public void DisposeTempFiles(string fileName)
        {
            string baseDirectory = Environment.CurrentDirectory;
            string tempDirectory = baseDirectory + "/Pod/";
            var localFile = Path.Combine(tempDirectory, $"{fileName}.pdf");
            var localFileInfo = new FileInfo(localFile);

            if (localFileInfo.Exists)
            {
                localFileInfo.Delete();
            }

            int count = Directory.EnumerateFiles(tempDirectory).Count();
            if (count >= 10000)
            {
                foreach (FileInfo file in new DirectoryInfo(tempDirectory).GetFiles())
                {
                    file.Delete();
                }
            }
        }

        private string GetBucketName(string env)
        {
            var bucketExtension = "sroi";

            if (env.Equals("production"))
            {
                return $"impactly-production-{bucketExtension}";
            }
            else if (env.Equals("staging"))
            {
                return $"impactly-staging-{bucketExtension}";
            }
            return $"impactly-staging-{bucketExtension}";
        }
    }
}
