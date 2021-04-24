using ShopNuocHoa.Application.Catalog.Product.DTO;
using ShopNuocHoa.Application.Catalog.Product.DTO.Manage;
using ShopNuocHoa.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Application.Catalog.Product
{
    public interface IPublicProdctServices
    {
        PagedViewModel<ProductViewModels> GetAllByCategoryId(GetProductPagingRequest request);
    }
}
