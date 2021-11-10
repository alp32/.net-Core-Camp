using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı kısmı boş geçilemez.");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Boş Geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre Boş Geçilemez").Must(IsPasswordValid).WithMessage("Parolanız en az sekiz karakter, en az bir büyük ve küçük  harf ,en az 1 noktalama işareti ve bir sayı içermelidir!");
            
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen En az 2 karakter Girişi Yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("Lütfen En fazla 50 karakterlik veri girişi Yapın.");
        }
        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[!@``#$&*.])(?=.*[0-9])(?=.*[a-z]).{8,}$");
            return regex.IsMatch(arg);
        }
    }
}
