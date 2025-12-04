using Courier.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Model
{
    public class CargoOrder

    {
        public static int count = 0;
        public int Id ;
        public int CustomerId;
        public int CourierId;
        public int TotalPrice;
        public OrderStatus orderStatus;
        public DateTime CreatedAt;

        public CargoOrder(int customerId, int courierId ,int  totalPrice, OrderStatus orderStatus)
        {
            count++;
            Id = count;
            CustomerId = customerId;
            CourierId = courierId;
            TotalPrice = totalPrice;
            this.orderStatus = orderStatus;
            CreatedAt = DateTime.Now;
        }
     public void UpdateStatus(OrderStatus status)
        {
            if(status==OrderStatus.Delivered|| status == OrderStatus.Cancelled)
            {
                Console.WriteLine("you can't change status");
                return;
            }
            orderStatus = status;

        }
    }
}
