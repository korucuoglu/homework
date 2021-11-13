using System;
using System.Threading.Tasks;
using AutoMapper;
using BookStore.Controllers;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Entity;
using BookStore.Models;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.Books
{
    public class CreateBookTests : IClassFixture<CommonTestFixture>
    {

        private readonly IBookService _service;
        private readonly IMapper _mapper;

        private readonly DataContext _context;

        public CreateBookTests(CommonTestFixture testFixture)
        {
            _service = testFixture.BookService;
            _mapper = testFixture.Mapper;
            _context = testFixture.Context;
        }


        [Fact]
        public async Task WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturnAsync()
        {

            // Zaten var olan bir kitabın ismi verildiğinde geriye Invalid Operation Exeption dönmesi gerekmektedir. 

            // Arrange (Hazırlık)

            var book = new Book() { Title = "ShouldBeReturn", PageCount = 100, Publishdate = new DateTime(1990, 01, 10), GenreId = 1 };

            await _service.AddAsync<BookGetViewModel>(book);
            await _context.SaveChangesAsync();

            var controller = new BooksController(_mapper, _service);

            var model = new BookCreateViewModel { Title = "ShouldBeReturn" };


            // Act (Çalıştırma)

            var data = Assert.IsType<ObjectResult>(controller.Add(model).Result).Value;
            var result = Assert.IsType<Response<BookGetViewModel>>(data);
            Assert.Equal(false, result.IsSuccessful);
            Assert.Contains(result.Errors, x => x == "Kitap zaten mevcut");
            Assert.Equal<int>(500, result.StatusCode);

            // Assert  (Doğrulama)

        }


        [Theory]
        [InlineData()]
        [InlineData()]
        [InlineData(38)]
        [InlineData(46)]
        public void WhenNotExistBookIdGiven_ResponseIsSucsessfullFalse_ShouldBeReturn(int id)
        {

            var controller = new BooksController(_mapper, _service);

            var redirect = Assert.IsType<ObjectResult>(controller.Delete(id));

            var data = Assert.IsType<Response<NoContent>>(redirect.Value);

            Assert.Equal(false, data.IsSuccessful);

        }
    }
}
