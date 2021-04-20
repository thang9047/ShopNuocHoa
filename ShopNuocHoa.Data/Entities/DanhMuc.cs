using ShopNuocHoa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class DanhMuc
    {
        public int MaDm { get; set; }
        public string TenDm { get; set; }

        public int? ParentId { get; set; }

        public Status Status { get; set; }

        public List<SanPham> Products { get; set; }
    }
}
