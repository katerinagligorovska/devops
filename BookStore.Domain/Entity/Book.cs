﻿using BookStore.Domain.Relations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.Entity
{
    public class Book : BaseEntity
    {
        [Required]
        public string BookName { get; set; }
        [Required]
        public string BookImage { get; set; }
        [Required]
        public string BookDescription { get; set; }
        [Required]
        public int Price { get; set; }
       
        public string Genre { get; set; }
        public virtual ICollection<BookInShoppingCart> BookInShoppingCarts { get; set; }
        public virtual ICollection<BookInOrder> BookInOrders { get; set; }
    }
}
