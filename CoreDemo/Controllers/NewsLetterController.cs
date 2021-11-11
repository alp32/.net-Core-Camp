using BusinessLayer.Concrete;
using CoreDemo.Models.AraModeller;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nm = new NewsLetterManager(new EfNewsLetterRepository());

        
       [AllowAnonymous]
        public async Task<IActionResult> SubscribeMail(NewsLetter p)
        {
            try
            {
                p.MailStatus = true;
                await nm.AddNewsLetter(p); 

                return Json(new ResultModel { Success = true });
            }
            catch (System.Exception ex)
            {
                return Json(new ResultModel { Success = false, Message = ex.Message });
            }
           
           
             
           
        }
    }
}
