using Egitim.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.FluentValidation
{
    public class OkulYorumValidator:AbstractValidator<OkulYorum>
    {
        public OkulYorumValidator()
        {
            RuleFor(c => c.Ad).Length(1, 30).WithMessage("Ad alanı max 30 karakter olmalı.").NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(c => c.Soyad).Length(1, 30).WithMessage("Soyad alanı max 30 karakter olmalı.").NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(c => c.Mail).Length(1, 100).WithMessage("Mail alanı max 100 karakter olmalı.").NotEmpty().WithMessage("Mail alanı boş geçilemez");
            RuleFor(c => c.YorumIcerik).Length(1, 1500).WithMessage("YorumIcerik alanı max 1500 karakter olmalı.").NotEmpty().WithMessage("YorumIcerik alanı boş geçilemez");
            RuleFor(c => c.Puan).NotEmpty().WithMessage("Puan verilmeli!");
            RuleFor(c => c.OkulId).NotEmpty().WithMessage("OkulId alanı boş geçilemez!");
        }
    }
}
