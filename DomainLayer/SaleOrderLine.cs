using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class SaleOrderLine
    {
        int Quantity { get; set; }
        float Price { get; set; }
        bool Recieved { get; set; }
    }
}
