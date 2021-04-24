using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class Role:IdentityRole<Guid>
    {
        public string Mota { get; set; }
    }
}
