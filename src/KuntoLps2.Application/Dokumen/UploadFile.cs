using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuntoLps2.Dokumen
{
    public class UploadFile : Entity<int>
    {
        public string FileName { get; set; }
        public string Path { get; set; }
    }
}
