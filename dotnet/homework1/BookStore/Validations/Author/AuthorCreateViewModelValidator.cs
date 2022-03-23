using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validations.Book
{

    public class AuthorCreateViewModelValidator : AbstractValidator<AuthorCreateViewModel>
    {

        public AuthorCreateViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar ismi boş olamaz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Yazar soyismi boş olamaz");

        }
    }

    public class AuthorCreateViewModelWithBooksValidator : AbstractValidator<AuthorCreateViewModelWithBooks>
    {

        public AuthorCreateViewModelWithBooksValidator()
        {

            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar ismi boş olamaz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Yazar soyismi boş olamaz");
            RuleFor(x => x.Books.Count).GreaterThan(0).WithMessage("Yazarın kitap bilgisini girmek zorunludur");

        }
    }

}