using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class CaSi
    {
        public string MaCaSi { get; set; }
        public string TenCaSi { get; set; }

        public CaSi()
        {
        }

        public CaSi(string maCaSi, string tenCaSi)
        {
            MaCaSi = maCaSi;
            TenCaSi = tenCaSi;
        }
    }
}
