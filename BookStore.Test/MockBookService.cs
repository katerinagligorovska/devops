using BookStore.Service.Implementation;
namespace BookStore.Test;

public class MockBookService
{
        [Fact]
        public void GetAllBooks_ReturnsAllBooks()
        {
            // Arrange
            var fakeBookRepository = new MockBookRepository().CreateMockBookRepository();
            var bookService = new BookService(fakeBookRepository.Object);

            // Act
            var books = bookService.GetAllBooks();

            // Assert
            Assert.Equal(3, books.Count());
            Assert.Equal("Book 1", books.First().BookName);
            
        }
}

