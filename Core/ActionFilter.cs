using blog.gze1206.net.Controllers;
using blog.gze1206.net.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace blog.gze1206.net.Core;

[AttributeUsage(AttributeTargets.Class)]
public class ActionFilter : Attribute, IActionFilter
{
    public void OnActionExecuted(ActionExecutedContext context)
    {
    }
    
    public void OnActionExecuting(ActionExecutingContext context)
    {
        if (context.Controller is LayoutController layoutController)
        {
            layoutController.LayoutModel = new LayoutModel()
            {
                IsDarkMode = true
            };

            layoutController.ViewBag.LayoutModel = layoutController.LayoutModel;
        }
    }
}