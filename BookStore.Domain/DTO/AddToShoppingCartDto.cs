using BookStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Domain.DTO
{
    public class AddToShoppingCartDto
    {
        public Book SelectedBook { get; set; }

        public Guid SelectedBookId { get; set; }

        public int Quantity { get; set; }
    }
}
