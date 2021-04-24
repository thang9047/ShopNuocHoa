
using ShopNuocHoa.Application.Catalog.Product.DTO;
using ShopNuocHoa.Application.Catalog.Product.DTO.Manage;
using ShopNuocHoa.Application.Dtos;
using ShopNuocHoa.Data.EF;
using ShopNuocHoa.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopNuocHoa.Application.Catalog.Product
{
    public class ManageProductService : IManageProductServices
    {
        private readonly ShopNuocHoaDBContext _db;
        public ManageProductService(ShopNuocHoaDBContext db)
        {
            _db = db;
        }
        public async Task<int> CreateProduct(ProductCreateRequest request)
        {
            var product = new SanPham()
            {
                Gia = request.Gia,
                TenSp = request.TenSp,
                NhanHieu = request.NhanHieu,
                GioiTinh = request.GioiTinh,
                XuatXu = request.XuatXu,
                TgPhatHanh = request.TgPhatHanh,
                NongDo = request.NongDo,
                NhaPC = request.NhaPC,
                NhomHuong = request.NhomHuong,
                PhongCach = request.PhongCach,
                MoTa = request.MoTa,
                MauSac = request.MauSac,
                BoSuuTap = request.BoSuuTap,
                HuongDacTrung = request.HuongDacTrung,
                ProductImages = new List<SanPhamAnh>()
                {
                    new SanPhamAnh()
                    {
                        ImagePath = request.

                    }
                }
            };
            _db.SanPhams.Add(product);
            return await _db.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            throw new NotImplementedException();
        }


        public async Task<PagedViewModel<ProductViewModels>> GetAllPaging(GetProductPagingRequest request)
        {
            throw new NotImplementedException();
        }

        public async Task<int> UpdateProduct(ProductEditRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateStock(int productId, int addedQuantity)
        {
            throw new NotImplementedException();
        }

        Task<List<ProductViewModels>> IManageProductServices.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
