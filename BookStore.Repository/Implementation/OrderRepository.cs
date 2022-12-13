﻿using BookStore.Domain.Entity;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Repository.Implementation
{

    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private DbSet<Order> entities;

        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            entities = context.Set<Order>();
        }
        public new List<Order> GetAll()
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BooksInOrder)
                .ToList();
        }
        public List<Order> GetAllOrdersForUser(string userId)
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BooksInOrder)
                .Where(p => p.UserId == userId)
                .ToList();
        }

        public Order GetOrderDetails(Order model)
        {
            return entities
               .Include(z => z.UserId)
               .Include(z => z.BooksInOrder)
               .Single(z => z.Id == model.Id);
        }
    }
}
