using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAS_PCD
{
    public class Options
    {
        public string FolderPath { get; set; }
        public int OpeningKernelSize { get; set; }
        public int ClosingKernelSize { get; set; }
        public int MinimalBlobSize { get; set; }
        public List<HsvColorRange> DaftarWarnaBangunan { get; set; }
    }
}
