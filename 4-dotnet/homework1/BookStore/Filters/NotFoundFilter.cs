using System;
using System.Threading.Tasks;
using BookStore.DatabaseOperations.Services.Abstract;
using BookStore.Shared;
using BookStore.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BookStore.Filters
{

    public class NotFoundFilter<TEntity> : IAsyncActionFilter where TEntity : class
    {
        private readonly IGenericService<TEntity> _service;

        public NotFoundFilter(IGenericService<TEntity> service)
        {
            _service = service;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var id = Convert.ToInt32(context.RouteData.Values["id"].ToString());

            var data = await _service.GetByIdAsync<TEntity>(id);

            if (data.Data != null)
            {
                await next();
            }

            var error = $"Id değeri {id} olan veri bulumamadı";

            context.Result = new NotFoundObjectResult(Response<NoContent>.Fail(error, 404));

        }
    }
}