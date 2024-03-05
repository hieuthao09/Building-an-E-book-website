using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dto
{
    public class TacGiaSach
    {
        public TacGiaSach() { }

        public TacGiaSach(string maTG, string maSach)
        {
            MaTG = maTG ?? throw new ArgumentNullException(nameof(maTG));
            MaSach = maSach ?? throw new ArgumentNullException(nameof(maSach));
        }

        string maTG;
        string maSach;

        public string MaTG { get => maTG; set => maTG = value; }
        public string MaSach { get => maSach; set => maSach = value; }
    }
}
