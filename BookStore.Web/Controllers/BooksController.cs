using BookStore.Domain.DTO;
using BookStore.Domain.Entity;
using BookStore.Domain.Identity;
using BookStore.Service.Interface;
using BookStore.Web.ViewModel;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BookStore.Web.Controllers
{
    public class BooksController : Controller
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult Index(string? title)
        {
            List<BookViewModel> model = new List<BookViewModel>();
            List<Book> books;
            if (title == null)
            {
                books = this._bookService.GetAllBooks();
            }
            else
            {
                books = this._bookService.GetAllBooksByTitle(title);
            }
            foreach (var book in books)
            {
                model.Add(new BookViewModel(
                    book.Id,
                    book.BookName,
                    book.BookImage,
                    book.BookDescription,
                    book.Genre,
                    book.Price
                ));
            }
            return View(model);
        }

        // GET: Books/Details/5
        public IActionResult Details(Guid id)
        {
            var book = this._bookService.GetDetailsForBook(id);
            return View(book);
        }

        public IActionResult Create()
        {
            return View(new CreateBookViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateBookViewModel book)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Invalid registration attempt");
                return View(book);
            }

            var newBook = new Book
            {
                BookName = book.BookName,
                BookImage = book.BookImage,
                BookDescription = book.BookDescription,
                Price = book.Price,
                Genre = book.Genre
            };
            this._bookService.CreateNewBook(newBook);
            return RedirectToAction("Index", "Books");
        }


        public IActionResult Edit(Guid id)
        {
            var book = this._bookService.GetDetailsForBook(id);
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Guid id, [Bind("Id,BookName,BookImage,BookDescription,Price,Rating,Genre")] Book book)
        {
            if (id != book.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    this._bookService.UpdeteExistingBook(book);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = this._bookService.GetDetailsForBook(id);
            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult AddBookToCard(Guid id)
        {
            var result = this._bookService.GetShoppingCartInfo(id);

            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBookToCard(AddToShoppingCartDto model)
        {

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this._bookService.AddToShoppingCart(model, userId);

            if (result)
            {
                return RedirectToAction("Index", "Books");
            }
            return View(model);
        }
        private bool BookExists(Guid id)
        {
            return _bookService.GetDetailsForBook(id) != null;
        }


        [HttpGet]
        [Authorize(Roles = RoleName.Admin)]
        public IActionResult ExportAllBooks()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.Admin)]
        public FileContentResult ExportAllBooks([Bind("Genre")] Book book)
        {
            string fileName = "Books-" + book.Genre + ".xlsx";
            string contentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
            using (var workbook = new XLWorkbook())
            {
                IXLWorksheet worksheet = workbook.Worksheets.Add("All books - " + book.Genre);
                worksheet.ColumnWidth = 50;
                worksheet.Cell(1, 1).Value = "Book Id";
                worksheet.Cell(1, 2).Value = "Book Name";
                worksheet.Cell(1, 3).Value = "Book Price";
                worksheet.Cell(1, 4).Value = "Genre";
                worksheet.Cell(1, 5).Value = "Book Description";
                worksheet.Cell(1, 6).Value = "Book Image";


                var result = this._bookService.GetAllBooksGenre(book.Genre);
                for (int i = 1; i <= result.Count(); i++)
                {
                    var item = result[i - 1];
                    worksheet.Cell(i + 1, 1).Value = item.Id.ToString();
                    worksheet.Cell(i + 1, 2).Value = item.BookName;
                    worksheet.Cell(i + 1, 3).Value = item.Price.ToString() + "$";
                    worksheet.Cell(i + 1, 4).Value = item.Genre;
                    worksheet.Cell(i + 1, 5).Value = item.BookDescription;
                    worksheet.Cell(i + 1, 6).Value = item.BookImage;

                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();

                    return File(content, contentType, fileName);
                }
            }
        }

    }
}
