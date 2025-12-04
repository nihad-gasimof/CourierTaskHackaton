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
        private static int count = 0;
        public int Id { get; private set; }
        public int CustomerId { get; set; }
        public int CourierId { get; set; }
        public int TotalPrice { get; set; }
        public OrderStatus orderStatus { get; set; }
        public DateTime CreatedAt { get; private set; }

        public CargoOrder(int customerId, int courierId, int totalPrice, OrderStatus orderStatus)
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
            if (status == OrderStatus.Delivered || status == OrderStatus.Cancelled)
            {
                Console.WriteLine("you can't change status");
                return;
            }
            orderStatus = status;

        }
    }
}