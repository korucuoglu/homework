using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validation
{

    public class CreateBookViewModelValidator : AbstractValidator<CreateBookViewModel>
    {

        public CreateBookViewModelValidator()
        {
            RuleFor(x => x.GenreId).NotEmpty().WithMessage("Genre türü boş olamaz");
            RuleFor(x => x.Title).NotNull().NotEmpty().WithMessage("Başlık boş olamaz");
        }
    }

}