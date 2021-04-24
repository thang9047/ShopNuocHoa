using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Application.Catalog.Product.DTO.Manage
{
    public class ProductEditRequest
    {
        public string TenSp { get; set; }

        public string NhanHieu { get; set; }

        public string GioiTinh { get; set; }

        public double Gia { get; set; }

        public string XuatXu { get; set; }

        public DateTime? TgPhatHanh { get; set; }

        public string NongDo { get; set; }

        public string NhaPC { get; set; }

        public string NhomHuong { get; set; }

        public string PhongCach { get; set; }

        public string MoTa { get; set; }

        public string MauSac { get; set; }

        public string BoSuuTap { get; set; }

        public string HuongDacTrung { get; set; }

        public string Anh { get; set; }
    }
}
