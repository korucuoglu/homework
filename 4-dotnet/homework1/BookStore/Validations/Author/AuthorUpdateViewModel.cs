using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validations.Book
{

    public class AuthorUpdateViewModelValidator : AbstractValidator<AuthorUpdateViewModel>
    {

        public AuthorUpdateViewModelValidator()
        {
            // RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id türü boş olamaz");
            RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id boş olamaz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Yazar ismi boş olamaz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Yazar soyismi boş olamaz");
        }
    }

}