using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Common.Interface.IService
{
    public interface IFileUploadService
    {
        Task<string?> UploadFile(IBrowserFile file);
    }
}
