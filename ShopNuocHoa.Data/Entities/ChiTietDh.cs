using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class ChiTietDh
    {
        public int OrderId { set; get; }
        public int ProductId { set; get; }
        public int SoLuong { set; get; }
        public decimal ThanhTien { set; get; }

        public SanPham SanPham { get; set; }

        public DonHang DonHang { get; set; }
    }
}
