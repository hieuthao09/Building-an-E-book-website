using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class TacGia
    {
        public TacGia() { }

        public TacGia(string tenTG)
        {
            TenTG = tenTG ?? throw new ArgumentNullException(nameof(tenTG));
        }

        string maTG;
        string tenTG;

        public string MaTG { get => maTG; set => maTG = value; }
        public string TenTG { get => tenTG; set => tenTG = value; }
    }
}
