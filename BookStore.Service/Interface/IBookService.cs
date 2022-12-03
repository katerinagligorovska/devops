using BookStore.Domain.DTO;
using BookStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Interface
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetDetailsForBook(Guid? id);
        List<Book> GetAllBooksGenre(string genre);
        List<Book> GetAllBooksByTitle(string title);
        void CreateNewBook(Book p);
        void UpdeteExistingBook(Book p);
        AddToShoppingCartDto GetShoppingCartInfo(Guid? id);
        void DeleteBook(Guid id);
        bool AddToShoppingCart(AddToShoppingCartDto item, string userID);
    }
}
