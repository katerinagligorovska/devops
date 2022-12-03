﻿using BookStore.Domain.Entity;
using BookStore.Domain;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Implementation
{

    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<Order> entities;
        string errorMessage = string.Empty;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<Order>();
        }
        public List<Order> getAllOrders()
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BookInOrders)
                .Include("BookInOrders.Book")
                .ToListAsync().Result;
        }
        public List<Order> getAllOrdersForUser(string userId)
        {
            return entities
                .Include(z => z.User)
                .Include(z => z.BookInOrders)
                .Include("BookInOrders.Book")
                .Where(p => p.UserId == userId)
                .ToListAsync().Result;
        }

        public Order getOrderDetails(BaseEntity model)
        {
            return entities
               .Include(z => z.User)
               .Include(z => z.BookInOrders)
               .Include("BookInOrders.Book")
               .SingleOrDefaultAsync(z => z.Id == model.Id).Result;
        }
    }
}
