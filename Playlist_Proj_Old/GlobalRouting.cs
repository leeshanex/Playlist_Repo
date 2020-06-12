using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Playlist_Project
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimsPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.RouteData.Values["controller"]; 
            if (controller.Equals("Home")) 
            { 
                if (_claimsPrincipal.IsInRole("NewUser")) 
                { 
                    context.Result = new RedirectToActionResult("Index", "New Users", null); 
                } 
                
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
           
        }
    }
}
