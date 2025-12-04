using Courier.Enums;
using Courier.Model;
using Courier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Services
{
    internal class CargoService:ICargoService
    {
        public List<Customer> Customers { get; private set; } = new();
        public List<Courier.Models.Courier> Couriers { get; private set; } = new();
        public List<CargoOrder> Orders { get; private set; } = new();

        List<Customer> ICargoService.Customers => throw new NotImplementedException();

        List<Models.Courier> ICargoService.Couriers => throw new NotImplementedException();

        List<CargoOrder> ICargoService.Orders => throw new NotImplementedException();

        async Task ICargoService.AddCourier(Models.Courier courier)
        {
            Couriers.Add(courier);
            await Task.CompletedTask;
        }

        async Task ICargoService.AddCustomer(Customer customer)
        {
           Customers.Add(customer);
            await Task.CompletedTask;
        }

        async Task ICargoService.CompleteOrder(int orderId)
        {
            var order = Orders.FirstOrDefault(o => o.Id == orderId);
            if (order == null)
                throw new Exception("Bu ID-də sifariş tapılmadı!");

            order.orderStatus=OrderStatus.Delivered;

            // Courieri yenidən aktiv edək
            var courier = Couriers.FirstOrDefault(c => c.Id == order.CourierId);
            if (courier != null)
                courier.IsAvailable = true;
            await Task.CompletedTask;

        }

        async Task ICargoService.CreateOrder(CargoOrder order)
        {
            var customer = Customers.FirstOrDefault(c => c.Id == order.CustomerId);
            if (customer == null)
                throw new Exception("Belə bir Customer tapılmadı!");

            var courier = Couriers.FirstOrDefault(c => c.Id == order.CourierId);
            if (courier == null)
                throw new Exception("Belə bir Courier tapılmadı!");

            if (!courier.IsAvailable)
                throw new Exception($"Kuryer ({courier.Name}) hazırda uyğun deyil!");

            courier.IsAvailable = false; 

            Orders.Add(order);
            await Task.CompletedTask;
        }
    }
}
