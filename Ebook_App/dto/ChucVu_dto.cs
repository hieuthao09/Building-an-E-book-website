using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class ChucVu_dto
    {
        public ChucVu_dto() { }

      
        public ChucVu_dto(string maCV, string tenCV)
        {
            MaCV = MaCV ?? throw new ArgumentNullException(nameof(MaCV));
            TenCV = tenCV ?? throw new ArgumentNullException(nameof(tenCV));
        }
        string maCV;
        string tenCV;

        public string MaCV { get => maCV; set => maCV = value; }
        public string TenCV { get => tenCV; set => tenCV = value; }
    }
}
