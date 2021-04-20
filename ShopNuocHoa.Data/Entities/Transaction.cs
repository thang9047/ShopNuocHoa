using ShopNuocHoa.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopNuocHoa.Data.Entities
{
    public class Transaction
    {
        public int Id { set; get; }
        public DateTime NgayThanhToan { set; get; }
        public string ExternalTransactionId { set; get; }
        public decimal TongTien { set; get; }
        public decimal Fee { set; get; }
        public string Result { set; get; }
        public string Message { set; get; }
        public TransactionStatus Status { set; get; }
        public string Provider { set; get; }
    }
}
