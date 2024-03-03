using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebook_Project.Models
{
    public class NhaXuatBanDTO
    {
        public string maNXB { get; set; }
        public string tenNXB { get; set; }

        public NhaXuatBanDTO(string maNXB, string tenNXB)
        {
            this.maNXB = maNXB;
            this.tenNXB = tenNXB;
        }
    }
}