using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterNotification:ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EfNotificationRepository());

        public IViewComponentResult Invoke(int id)
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
