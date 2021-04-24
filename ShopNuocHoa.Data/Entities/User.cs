using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }

        public List<GioHang> Carts { get; set; }

        public List<BinhLuan> BinhLuans { get; set; }

        public List<DonHang> DonHangs { get; set; }

        public List<Transaction> Transactions { get; set; }
    }
}
