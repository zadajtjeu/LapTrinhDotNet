using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class XuLi
    {
        int b, c;

        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }
        public XuLi() { }
        public XuLi(int b, int c)
        {
            this.B = b;
            this.C = c;
        }
        public string GiaiPT()
        {
            if (this.B == 0 && this.C != 0)
                return "PT vô nghiệm";
            else
                return ((double)-this.C / this.B).ToString();
        }
    }
}
