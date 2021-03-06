using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validations.Book
{

    public class UpdateBookViewModelValidator : AbstractValidator<BookUpdateViewModel>
    {

        public UpdateBookViewModelValidator()
        {
            // RuleFor(x => x.Id).GreaterThan(0).WithMessage("Id türü boş olamaz");
            RuleFor(x => x.GenreId).NotEmpty().WithMessage("Genre türü boş olamaz");
            RuleFor(x => x.Title).NotEmpty().MinimumLength(4).WithMessage("Başlık boş olamaz");
        }
    }

}