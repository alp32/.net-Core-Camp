using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public class NewsLetterManager:INewsLetterService
    {
        INewsLetterDal _newsletterDal;

        public NewsLetterManager(INewsLetterDal newsletterDal)
        {
            _newsletterDal = newsletterDal;
        }

        public Task AddNewsLetter(NewsLetter newsLetter)
        {
            _newsletterDal.Insert(newsLetter);
            return Task.CompletedTask;
        }
    }
}
