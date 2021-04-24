using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Application.Dtos
{
    public class PagedViewModel<T>
    {
        public int TotolRecord { get; set; }

        public List<T> items { get; set; }
    }
}
