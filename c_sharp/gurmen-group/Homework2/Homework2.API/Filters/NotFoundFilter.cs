using FileUpload.Shared.Wrappers;
using Homework2.API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace Homework2.API.Filters
{
    public class NotFoundFilter: ActionFilterAttribute
    {
        private readonly IAuthorRepository _repository;

        public NotFoundFilter(IAuthorRepository repository)
        {
            _repository = repository;
        }

        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            int id = int.Parse(context.RouteData.Values["id"].ToString());

            var result = await _repository.Any(id);

            if (!result)
            {
                context.Result = new NotFoundObjectResult(Response<NoContent>.Fail("NotFound -> Böyle bir veri bulunamadı.", 404));
                return;
            }

            await next();
        }
    }
}
