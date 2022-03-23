using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validations.Book
{

    public class CreateBookViewModelValidator : AbstractValidator<BookCreateViewModel>
    {

        public CreateBookViewModelValidator()
        {
            RuleFor(x => x.GenreId).NotEmpty().WithMessage("Genre türü boş olamaz");
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Başlık boş olamaz");
        }
    }

}