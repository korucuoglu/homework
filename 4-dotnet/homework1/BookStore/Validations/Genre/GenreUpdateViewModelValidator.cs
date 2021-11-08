using BookStore.ViewModels.Genre;
using FluentValidation;

namespace BookStore.Validations.Genre
{
    public class GenreUpdateViewModelValidator : AbstractValidator<GenreUpdateViewModel>
    {
        public GenreUpdateViewModelValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id alanı boş bırakılamaz");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş bırakılamaz");

        }
    }
}