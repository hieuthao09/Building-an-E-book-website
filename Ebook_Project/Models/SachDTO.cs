using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebook_Project.Models
{
    public class SachDTO
    {
        public SachDTO()
        {
        }

        public string MASACH { get; set; }
        public string TENSACH { get; set; }
        public string MOTA { get; set; }
        public decimal GIABAN { get; set; }
        public string TENFILESACH { get; set; }
        public Nullable<System.DateTime> NGAYDANGTAI { get; set; }
        public string MATL { get; set; }
        public NhaXuatBanDTO nxb { get; set; }
        public string FILEHINH { get; set; }

        public SachDTO(string mASACH, string tENSACH, string mOTA, decimal gIABAN, string tENFILESACH, DateTime? nGAYDANGTAI, string mATL, NhaXuatBanDTO nxb, string FileHinh)
        {
            MASACH = mASACH;
            TENSACH = tENSACH;
            MOTA = mOTA;
            GIABAN = gIABAN;
            TENFILESACH = tENFILESACH;
            NGAYDANGTAI = nGAYDANGTAI;
            MATL = mATL;
            this.nxb = nxb;
            FILEHINH = FileHinh;
        }
    }
}