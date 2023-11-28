using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.MultiTenancy;

namespace KuntoLps2.Dokumen.Dto
{
    public class UploadFileDto : EntityDto
    {
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
