using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion7.Models.Repositories;
using Lektion7.Models.Entities;

namespace Lektion7.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/

        public ActionResult Index(int id)
        {
            var post = Repository.Instance.All<Post>().OrderBy(p => p.CreateDate).Skip(0).FirstOrDefault();

            return View();
        }

    }
}
