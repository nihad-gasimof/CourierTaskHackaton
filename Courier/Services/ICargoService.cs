using Courier.Model;
using Courier.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier.Services
{
    public interface ICargoService
    {
        List<Customer> Customers { get; }
        List<Courier.Models.Courier> Couriers { get; }
        List<CargoOrder> Orders { get; }

        Task AddCustomer(Customer customer);
        Task AddCourier(Courier.Models.Courier courier);
        Task CreateOrder(CargoOrder order);
        Task CompleteOrder(int orderId);
    }
}
