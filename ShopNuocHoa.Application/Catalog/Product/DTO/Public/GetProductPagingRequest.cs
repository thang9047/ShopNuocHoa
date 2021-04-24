using ShopNuocHoa.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Application.Catalog.Product.DTO.Public
{
    public class GetProductPagingRequest : PagingResult
    {
        public int categoryId { get; set; }
    }
}
