using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Services.Logger;
using BookStore.Shared;
using BookStore.ViewModels;
using BookStore.ViewModels.Books;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BookStore.Filters
{
    public class ValidationFilter : ActionFilterAttribute
    {
        private readonly ILoggerService _logger;

        public ValidationFilter(ILoggerService logger)
        {
            _logger = logger;
        }


        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {

                List<string> errors = new();

                IEnumerable<ModelError> modelErrors = context.ModelState.Values.SelectMany(i => i.Errors);

                foreach (var item in modelErrors)
                {
                    errors.Add(item.ErrorMessage);
                }

                string message = $"[Error] HTTP {context.HttpContext.Request.Method} - {context.HttpContext.Request.Path}";
                // System.Console.WriteLine(message);
                _logger.Write(message);

                context.Result = new BadRequestObjectResult(Response<NoContent>.Fail(errors, 400));

            }
        }
    }
}