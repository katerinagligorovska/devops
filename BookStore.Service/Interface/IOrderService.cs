using BookStore.Domain.Entity;
using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Interface
{
    public interface IOrderService
    {
        List<Order> getAllOrders(string userId);
        public Order getOrderDetails(BaseEntity model);
    }
}
