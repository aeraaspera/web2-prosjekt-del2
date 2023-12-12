using Blog.Common.Interface.IService;
using Microsoft.AspNetCore.Components.Forms;

namespace Blog.Server.Service
{
    public class FileUploadService : IFileUploadService
    {
        private IWebHostEnvironment _webHostEnvironment;

        public FileUploadService(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public async Task<string?> UploadFile(IBrowserFile file)
        {
            try
            {
                if (file is not null)
                {
                    var uploadPath = Path.Combine(_webHostEnvironment.WebRootPath, "uploads", file.Name);

                    using (var stream = file.OpenReadStream())
                    {
                        var fileStream = File.Create(uploadPath);
                        await stream.CopyToAsync(fileStream);
                        fileStream.Close();
                        return file.Name;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"File upload failed: {ex.Message}");
                return String.Empty;
            }

            return null;
        }
    }
}
