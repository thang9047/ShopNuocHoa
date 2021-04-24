using ShopNuocHoa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class DonHang
    {
        public int MaDh { get; set; }
        public DateTime? NgayLap { get; set; }

        public Guid UserId { get; set; }

        public string NguoiNhan { get; set; }

        public string DiaChiGiaoHang { get; set; }
        public string Email { get; set; }

        public string  SDT { get; set; }
        public DonHangStatus Status { get; set; }

        public List<ChiTietDh> OrderDetails { get; set; }

        public User User { get; set; }
    }
}
