using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ebook_Project.Models
{
    public class TinTucDTO
    {
        public string MaTT { get; set; }
        public string TieuDe { get; set; }
        public string NoiDungTT { get; set; }
        public Nullable<System.DateTime> Thoigian { get; set; }
        public string MoTa { get; set; }
        public string HinhAnh { get; set; }
    }
}