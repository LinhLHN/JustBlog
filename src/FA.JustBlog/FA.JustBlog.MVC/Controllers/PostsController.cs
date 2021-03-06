using FA.JustBlog.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace FA.JustBlog.MVC.Controllers
{
    public class PostsController : Controller
    {
        private readonly IPostServices _postServices;

        public PostsController(IPostServices postServices)
        {
            _postServices = postServices;
        }

        public async Task<ActionResult> Details(int year, int month, string urlSlug)
        {
            var post = await _postServices.GetPostsByDateAndUrlSlugAsync(year, month, urlSlug);
            return View(post);
        }
    }
}