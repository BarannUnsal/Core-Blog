using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().NotNull().MinimumLength(2).MaximumLength(50).WithMessage("Yazar ismi boş geçilemez");
            RuleFor(x => x.Mail).EmailAddress().NotNull().NotEmpty().MinimumLength(4).WithMessage("Mail adresi boş geçilemez");
            RuleFor(p => p.Mail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre bos gecilemez");
            RuleFor(p => p.Password).Matches(@"[A-Z]+").WithMessage("Sifre en azı bir büyük harfden ibaret olmalıdır.");
            RuleFor(p => p.Password).Matches(@"[a-z]+").WithMessage("Sifre en azı bir kicik harfden ibaret olmalıdır.");
            RuleFor(p => p.Password).Matches(@"[0-9]+").WithMessage("Sifre en azı bir rakamdan ibaret olmalıdır.");
        }
    }
}
