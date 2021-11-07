using BookStore.ViewModels.Books;
using FluentValidation;

namespace BookStore.Validation
{

    public class UpdateBookViewModelValidator : AbstractValidator<UpdateBookViewModel>
    {

        public UpdateBookViewModelValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id türü boş olamaz");
            RuleFor(x => x.GenreId).NotEmpty().WithMessage("Genre türü boş olamaz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık boş olamaz");
        }
    }

}