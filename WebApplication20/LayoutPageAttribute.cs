using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using WebApplication20.Models;

namespace WebApplication20
{
    public class LayoutPageAttribute : ActionFilterAttribute
    {
        private string _connectionString;

        public LayoutPageAttribute(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("ConStr");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = (Controller) context.Controller;
            controller.ViewBag.Something = _connectionString;
            base.OnActionExecuted(context);
        }
    }
}
