using System;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Services.Logger;
using BookStore.Shared;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.Filters
{

    public class NotFoundFilter<TEntity> : IAsyncActionFilter where TEntity : class
    {
        private readonly IGenericService<TEntity> _service;
        private readonly ILoggerService _logger;

        public NotFoundFilter(IGenericService<TEntity> service, ILoggerService logger)
        {
            _service = service;
            _logger = logger;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {


            _logger.Write(" [NotFoundFilter] starting");

            var id = context.RouteData.Values["id"].ToString();

            int n;
            bool isNumeric = int.TryParse(id, out n);

            if (!isNumeric)
            {
                _logger.Write(" [NotFoundFilter] isNumeric False");
                await next();
            }
            var data = await _service.GetByIdAsync<TEntity>(n);

            if (data.Data != null)
            {
                await next();
            }

            var error = $"Id değeri {id} olan veri bulumamadı";

            context.Result = new NotFoundObjectResult(Response<NoContent>.Fail(error, 404));

        }
    }
}