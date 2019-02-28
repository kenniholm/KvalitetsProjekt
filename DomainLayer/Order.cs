using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Order
    {
        List<SaleOrderLine> saleorderlines = new List<SaleOrderLine>();

        Customer Ordercustomer { get; set; }
        int OrderId { get; set; }
        string Orderdate { get; set; }
        string Deliverydate { get; set; }
        bool Picked { get; set; }

        public void AddOrderLine(SaleOrderLine sol)
        {
            saleorderlines.Add(sol);
        }
    }
}
