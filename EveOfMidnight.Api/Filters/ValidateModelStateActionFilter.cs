using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace EveOfMidnight.Api.Filters;

public class ValidateModelStateActionFilter : IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext filterContext)
    {

        if (!filterContext.ModelState.IsValid)
        {
            if (filterContext.HttpContext.Request.Method is "GET")
            {
                var result = new BadRequestResult();

                filterContext.Result = result;
            }
            else
            {
                var serializerSettings = new JsonSerializerOptions
                {
                    ReferenceHandler = ReferenceHandler.IgnoreCycles
                };

                var content = JsonSerializer.Serialize(filterContext.ModelState, serializerSettings);

                var result = new ContentResult
                {
                    Content = content,
                    ContentType = MediaTypeNames.Application.Json
                };

                filterContext.HttpContext.Response.StatusCode = 400;

                filterContext.Result = result;
            }
        }
    }

    public void OnActionExecuting(ActionExecutingContext filterContext)
    {
    }
}