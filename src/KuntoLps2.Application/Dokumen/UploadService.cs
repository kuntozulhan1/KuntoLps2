using Abp.Authorization;
using Abp.EntityFrameworkCore;
using KuntoLps2.Authorization;
using KuntoLps2.Dokumen.Dto;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace KuntoLps2.Dokumen
{
    [AbpAuthorize(PermissionNames.Pages_Users)]
    public class UploadService : IUploadService
    {
        public async Task<bool> UploadFileAsync(string name, IFormFile file)
        {
            Guid id = new Guid();
            var stream = new MemoryStream();
            file.OpenReadStream().CopyTo(stream);
            int chunckSize = 2097152;
            int totalChunks = (int)(file.Length / chunckSize);
            if (file.Length % chunckSize != 0)
            {
                totalChunks++;
            }

            for (int i = 0; i < totalChunks; i++)
            {
                long position = (i * (long)chunckSize);
                int toRead = (int)Math.Min(file.Length - position, chunckSize);
                byte[] buffer = new byte[toRead];

                await stream.ReadAsync(buffer, 0, buffer.Length);

                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    form.Add(new ByteArrayContent(buffer), "files", name);
                    form.Add(new StringContent(id.ToString()), "id");
                    var meta = JsonConvert.SerializeObject(new DataUpload
                    {
                        UploadUid = id.ToString(),
                        FileName = name,
                        ChunkIndex = i,
                        TotalChunks = totalChunks,
                        TotalFileSize = file.Length,
                        ContentType = "application/unknown"
                    });
                    form.Add(new StringContent(meta), "metaData");

                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads", file.FileName);
                    using (var s = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(s);
                    }
                    return true;
                }
            }
            return true;
        }

    }
}
