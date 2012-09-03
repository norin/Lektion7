﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lektion7.Models.Repositories;
using Lektion7.Models.Entities;
using Lektion7.ViewModels;

namespace Lektion7.Controllers
{
    public class PostsController : Controller
    {
        //
        // GET: /Posts/

        public ActionResult Index(int id)
        {
            var post = Repository.Instance.GetPostByIndex(id);

            var vm = new PostViewModel() { MyPost = post, MyInteger = 5 };
            return View(post);
        }

    }
}