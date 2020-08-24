using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class DanhMucDTO
    {
        public string MaDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }
        public DanhMucDTO() { }
        public DanhMucDTO(string MaDanhMuc, string TenDanhMuc)
        {
            this.MaDanhMuc = MaDanhMuc;
            this.TenDanhMuc = TenDanhMuc;
        }

        public override string ToString()
        {
            return this.TenDanhMuc;
        }
    }
}
