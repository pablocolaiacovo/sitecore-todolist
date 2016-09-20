using Glass.Mapper.Sc;
using Glass.Mapper.Sc.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreTodo.Controllers
{
    public class BaseController : GlassController
    {
        protected BaseController(ISitecoreContext sitecoreContext) : base(sitecoreContext)
        {
        }

        protected bool LoggedIn()
        {
            return (System.Web.HttpContext.Current.User != null) && System.Web.HttpContext.Current.User.Identity.IsAuthenticated;
        }
    }
}