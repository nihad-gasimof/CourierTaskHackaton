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

        Task ICargoService.AddCourier(Models.Courier courier)
        {
            throw new NotImplementedException();
        }

        Task ICargoService.AddCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        Task ICargoService.CompleteOrder(int orderId)
        {
            throw new NotImplementedException();
        }

        Task ICargoService.CreateOrder(CargoOrder order)
        {
            throw new NotImplementedException();
        }
    }
}
