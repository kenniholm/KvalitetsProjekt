using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer
{
    public class Order
    {
        public int Id { get; private set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public bool Picked { get; set; }

        public Order()
        {
        }

        public Order(int id, string orderDate, string deliveryDate, int productId, int amount, bool picked)
        {
            Id = id;
            OrderDate = orderDate;
            DeliveryDate = deliveryDate;
            ProductId = productId;
            Amount = amount;
            Picked = picked;
        }

        public void AddOrderLine(int id, string orderDate, string deliveryDate, int productId, int amount, bool picked)
        {
            DBcontroller dbcontrol = new DBcontroller();
            dbcontrol.RegisterOrder(id, orderDate, deliveryDate, productId, amount, picked);
        }
    }
}
