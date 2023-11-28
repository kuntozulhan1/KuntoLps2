using Abp.Application.Services;
using KuntoLps2.MultiTenancy.Dto;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuntoLps2.Dokumen
{
    public interface IUploadService
    {
        Task<bool> UploadFileAsync(string name, IFormFile file);
    }

}
