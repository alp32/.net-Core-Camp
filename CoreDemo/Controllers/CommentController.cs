using BusinessLayer.Concrete;
using CoreDemo.Models.AraModeller;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        
        [HttpPost]
        public async Task<IActionResult> PartialAddCommentAsync(Comment p)
        {
            try
            {
                p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.CommentStatus = true;
                p.BlogID = 2;
               await cm.AddComment(p);
                return Json(new ResultModel { Success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new ResultModel { Success = false, Message = ex.Message });
            }


        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values=cm.GetList(id);
            return PartialView(values);
        }
    }
}
