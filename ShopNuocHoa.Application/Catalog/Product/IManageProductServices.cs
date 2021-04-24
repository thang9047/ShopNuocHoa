
using ShopNuocHoa.Application.Catalog.Product.DTO;
using ShopNuocHoa.Application.Catalog.Product.DTO.Manage;
using ShopNuocHoa.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopNuocHoa.Application.Catalog.Product
{
     public interface IManageProductServices
    {
        Task<int> CreateProduct(ProductCreateRequest request);

        Task<int> UpdateProduct(ProductEditRequest request);

        Task<bool> UpdateStock(int productId, int addedQuantity);

        Task<int> Delete(int productId);

        Task<List<ProductViewModels>> GetAll();

        Task<PagedViewModel<ProductViewModels>> GetAllPaging(GetProductPagingRequest request);
        
    }
}
