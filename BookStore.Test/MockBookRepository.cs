using Moq;
using System.Collections.Generic;
using BookStore.Domain.Entity;
using BookStore.Repository.Interface;

namespace BookStore.Test;

public class MockBookRepository
{
        public Mock<IRepository<Book>> CreateMockBookRepository()
        {
            // Create a list of fake books to use in the mock database
            var fakeBooks = new List<Book>
            {
                new Book { Id = Guid.NewGuid(), BookName = "Book 1", BookImage = "Image 1",BookDescription = "Desc1",Price = 100},
                new Book { Id = Guid.NewGuid(), BookName = "Book 2", BookImage="Image 2" ,BookDescription = "Desc2",Price=100},
                new Book { Id = Guid.NewGuid(), BookName = "Book 3", BookImage="Image 3" ,BookDescription = "Desc3",Price=100},

            };

            // Create a mock book repository using Moq
            var mockBookRepository = new Mock<IRepository<Book>>();

            // Setup the GetAllBooks method to return the list of fake books
            mockBookRepository.Setup(repo => repo.GetAll())
                .Returns(fakeBooks);
        
            // Return the mock book repository
            return mockBookRepository;
        }
}
