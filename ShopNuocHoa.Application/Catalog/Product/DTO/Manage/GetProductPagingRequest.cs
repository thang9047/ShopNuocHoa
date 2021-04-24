using ShopNuocHoa.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Application.Catalog.Product.DTO.Manage
{
    public class GetProductPagingRequest : PagingResult
    {
        public string keyword { get; set; }

        List<int> categoryId { get; set; }
    }
}
