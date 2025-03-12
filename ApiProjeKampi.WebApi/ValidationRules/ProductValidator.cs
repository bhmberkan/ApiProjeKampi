using ApiProjeKampi.WebApi.Entities;
using FluentValidation;

namespace ApiProjeKampi.WebApi.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty()
                .WithMessage("Ürün Adını Boş geçmeyin");

            RuleFor(x => x.ProductName).MinimumLength(2)
                .WithMessage("En az 2 karakter girebilirsiniz.");

            RuleFor(x => x.ProductName).MaximumLength(50)
                .WithMessage("En Fazla 50 karakter veri girişi yapın!");

            RuleFor(x=>x.Price).NotEmpty().WithMessage("Ürün Fiyatı boş geçilemez")
                .GreaterThan(0).WithMessage("Ürün fiyatı negatif olamaz.")
                .LessThan(1000).WithMessage("Ürün fiyatı 1000 den büyük olamaz");


            RuleFor(x => x.ProductDescription).NotEmpty().WithMessage("Ürün Açıklaması boş geçilemez");
                
        }

    }
}
