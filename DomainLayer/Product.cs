using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Product
    {
        int ProductId { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        float price { get; set; }
        int MinInStock { get; set; }
    }
}
