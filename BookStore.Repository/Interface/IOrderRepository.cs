using BookStore.Domain.Entity;
using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Interface
{
    public interface IOrderRepository
    {
        List<Order> getAllOrders();
        List<Order> getAllOrdersForUser(string userId);
        public Order getOrderDetails(BaseEntity model);
    }
}
