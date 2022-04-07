using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.MVC.Service
{
    public interface IFileInterface
    {
        string SaveImage (IFormFile newFile);
    }
}
