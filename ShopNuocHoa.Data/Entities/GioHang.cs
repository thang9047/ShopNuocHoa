using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class GioHang
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int  SoLuong { get; set; }
        public decimal TongTien { get; set; }

        public Guid UserId { get; set; }

        public SanPham Product { get; set; }

        public DateTime DateCreated { get; set; }

        public User User { get; set; }
    }
}
