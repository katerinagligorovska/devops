﻿using BookStore.Domain.Identity;
using BookStore.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext context;
        private DbSet<EShopAppUser> entities;
        string errorMessage = string.Empty;

        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
            entities = context.Set<EShopAppUser>();
        }
        public IEnumerable<EShopAppUser> GetAll()
        {
            return entities.AsEnumerable();
        }

        public EShopAppUser Get(string id)
        {
            return entities
               .Include(z => z.UserCart)
               .Include("UserCart.BookInShoppingCarts")
               .Include("UserCart.BookInShoppingCarts.CurrnetBook")
               .SingleOrDefault(s => s.Id == id);
        }
        public void Insert(
            EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Add(entity);
            context.SaveChanges();
        }

        public void Update(EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Update(entity);
            context.SaveChanges();
        }

        public void Delete(EShopAppUser entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            context.SaveChanges();
        }
    }
}
