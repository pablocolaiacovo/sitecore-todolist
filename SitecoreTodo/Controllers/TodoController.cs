using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Glass.Mapper.Sc;

namespace SitecoreTodo.Controllers
{
    public class TodoController : BaseController
    {

        public TodoController(ISitecoreContext sitecoreContext) : base(sitecoreContext)
        {
        }

        //public JsonResult GetTodoItems()
        //{
        //    var data = 
        //    return Json();
        //}
    }
}