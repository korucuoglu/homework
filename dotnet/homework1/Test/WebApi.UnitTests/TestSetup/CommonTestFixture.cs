using AutoMapper;
using BookStore.DatabaseOperations.Repositories.Abstract;
using BookStore.DatabaseOperations.Repositories.Concrete;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.DatabaseOperations.Services.Concrete;
using BookStore.Entity;
using BookStore.Mapping;
using BookStore.Models;
using Microsoft.EntityFrameworkCore;
using WebApi.UnitTests.DataGenerator;

namespace WebApi.UnitTests.TestSetup
{
    public class CommonTestFixture
    {

        public DataContext Context { get; set; }
        public IMapper Mapper { get; set; }
        public IBookService BookService { get; set; }
        public IRepository<Book> GenericBookRepository { get; set; }
        public IBookRepository BookRepository { get; set; }


        public CommonTestFixture()
        {
            var options = new DbContextOptionsBuilder<DataContext>().UseInMemoryDatabase(databaseName: "BookStoreTest").Options;

            Context = new DataContext(options);
            Context.Database.EnsureCreated(); // veritabanının oluşturulduğundan emin olmak için. 

            Mapper = new MapperConfiguration(cfg => { cfg.AddProfile<GeneralMapping>(); }).CreateMapper();

            GenericBookRepository = new Repository<Book>(Context);

            BookService = new BookService(GenericBookRepository, Mapper, BookRepository);

            Context.AddGenres();
            Context.AddAuthors();
            Context.SaveChanges();
        }
    }
}