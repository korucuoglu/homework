using FileUpload.Shared.Wrappers;
using Microsoft.AspNetCore.Mvc;

namespace Homework2.API.Controllers
{
    public class BaseApiController : ControllerBase
    {
        [NonAction]
        public IActionResult Result<T>(Response<T> response)
        {
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };

       
        }
    }
}
