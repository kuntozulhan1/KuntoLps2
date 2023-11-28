using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuntoLps2.Dokumen.Dto
{
    public class DataUpload
    {
        public string UploadUid { get; set; }
        public string FileName { get; set; }
        public int ChunkIndex { get; set; }
        public int TotalChunks { get; set; }
        public long TotalFileSize { get; set; }
        public string ContentType { get; set; }
    }
}
