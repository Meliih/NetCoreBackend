using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator() 
        { 
            RuleFor(p => p.ProductName)
                .NotEmpty().WithMessage("Ürün ismi boş olamaz")
                 .Length(2, 30)
                 //.Must(StartWithWithA)
                 ;

            RuleFor(p => p.UnitPrice).NotEmpty()
                .GreaterThanOrEqualTo(1)
                .GreaterThanOrEqualTo(10).When(p => p.CategoryID == 1);


        }

        private bool StartWithWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
