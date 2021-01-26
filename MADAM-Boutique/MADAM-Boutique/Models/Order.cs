using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MADAM_Boutique.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public System.DateTime OrderDate { get; set; }

        [ScaffoldColumn(false)]
        public decimal Total { get; set; }

        [ScaffoldColumn(false)]
        public string PaymentTransactionId { get; set; }

        [ScaffoldColumn(false)]
        public bool HasBeenShipped { get; set; }

        public Customer Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
    }
}
