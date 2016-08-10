﻿using System.Net;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class ErrorController : SkeletonMvcControllerBase
    {
        // GET: Error/401
        [ActionName("401")]
        public ActionResult Unauthorized()
        {
            Response.StatusCode = 401;
            return View();
        }

        // GET: Error/403
        [ActionName("403")]
        public ActionResult Forbidden()
        {
            Response.StatusCode = 403;
            return View();
        }

        // GET: Error/404
        [ActionName("404")]
        public ActionResult NotFound()
        {
            //return a status code for proper seo
            Response.StatusCode = 404;
            return View();
        }

        // GET: Error/500
        [ActionName("500")]
        public ActionResult Error()
        {
            //in the global.asax.cs code we handle the error. maybe we can send it to an email.
            //return a status code for proper seo
            Response.StatusCode = 500;
            return View();
        }
    }
}