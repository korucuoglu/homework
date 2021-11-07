using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStore.Filter
{

    class ValidationFilter<TEntity> : IAsyncActionFilter where TEntity : class
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {

                List<string> errors = new();

                IEnumerable<ModelError> modelErrors = context.ModelState.Values.SelectMany(i => i.Errors);

                foreach (var item in modelErrors)
                {
                    errors.Add(item.ErrorMessage);
                }

                context.Result = new BadRequestObjectResult(Response<TEntity>.Fail(errors, 400));

            }

            await next();

        }


    }
}