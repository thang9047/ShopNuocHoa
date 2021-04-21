using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class SanPhamAnh
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public string ImagePath { get; set; }

        public string Caption { get; set; }

        public bool IsDefault { get; set; }

        public int? SortOrder { get; set; }

        public SanPham Products { get; set; }
    }
}
