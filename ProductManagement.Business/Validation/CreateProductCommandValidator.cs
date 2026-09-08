using FluentValidation;
using ProductManagement.Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Business.Validation
{
    public class CreateProductCommandValidator:AbstractValidator<CreateProductDto>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name)
            .NotEmpty().WithMessage("Ürün adı boş olamaz.")
            .MaximumLength(150).WithMessage("Ürün adı en fazla 150 karakter olabilir.");

            RuleFor(p => p.Description)
                .MaximumLength(500).WithMessage("Açıklama en fazla 500 karakter olabilir.");

            RuleFor(p => p.Price)
                .GreaterThan(0).WithMessage("Ürün fiyatı 0'dan büyük olmalıdır.");

            RuleFor(p => p.Stock)
                .GreaterThanOrEqualTo(0).WithMessage("Stok miktarı negatif olamaz.");
        }
    }
}
