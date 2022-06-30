using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidations : AbstractValidator<Blog>
    {
        public BlogValidations()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Başlığı boş olamaz!")
                .MaximumLength(2).MaximumLength(75);
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog Başlığı boş olamaz")
                .MinimumLength(5);
            RuleFor(x => x.Category.CategoryName).NotEmpty().WithMessage("Blog Kategorisi boş olası!")
                .MinimumLength(3);
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog resmi seçin!");           
        }
    }
}
