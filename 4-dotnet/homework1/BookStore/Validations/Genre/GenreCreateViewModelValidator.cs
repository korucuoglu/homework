using BookStore.ViewModels.Genre;
using FluentValidation;

namespace BookStore.Validations.Genre
{
    public class GenreCreateViewModelValidator : AbstractValidator<GenreCreateViewModel>
    {
        public GenreCreateViewModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name alanı boş bırakılamaz");

        }
    }
}