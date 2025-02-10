using Amazon.S3;
using Impactly_PDF_Generator.Services;
using Impactly_PDF_Generator.Utilities;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllersWithViews()
    .AddNewtonsoftJson(options =>
    {
        options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
    });
builder.Services.AddRazorPages();
builder.Services.AddDefaultAWSOptions(builder.Configuration.GetAWSOptions());
builder.Services.AddAWSService<IAmazonS3>();
builder.Services.AddScoped<ISROIPDFGeneratorService, SROIPDFGeneratorService>();
builder.Services.AddScoped<IRendererService, RendererService>();
builder.Services.AddScoped<IPDFUploaderService, PDFUploaderService>();
builder.Services.AddScoped<INumberUtility, NumberUtility>();
builder.Services.AddScoped<IStringUtility, StringUtility>();
builder.Services.Configure<RazorViewEngineOptions>(options => {
    options.ViewLocationExpanders.Add(new ViewLocationExpander());
});


var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "PDF Generator Swagger!");
    });
}

app.UseFileServer(new FileServerOptions
{
    FileProvider = new PhysicalFileProvider(
            Path.Combine(Directory.GetCurrentDirectory(), "Pod")),
    RequestPath = "/Pod",
    EnableDirectoryBrowsing = false
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllers();
app.MapGet("/", () => "[Hello From PDF generator!]");
app.Run();