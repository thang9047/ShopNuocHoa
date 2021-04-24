using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class BinhLuan
    {
        public int Id { get; set; }

        public string HoTen { get; set; }

        public string Email { get; set; }

        public string NoiDung { get; set; }

        public Guid UserId { get; set; }

        public DateTime? ThoiGian { get; set; }

        public SanPham Product { get; set; }

        public User User { get; set; }
    }
}
