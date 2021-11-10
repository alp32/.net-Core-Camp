using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
  public  class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Geçemezsiniz");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini Boş Geçemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog görselini Boş Geçemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lütfen 150 Karakterden Daha az Veri girişi yapın");
            RuleFor(x => x.BlogTitle).MinimumLength(10).WithMessage("lütfen 10 karakterden daha fazla veri girişi yapın");
        }
    }
}
