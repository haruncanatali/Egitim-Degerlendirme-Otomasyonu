using Egitim.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.FluentValidation
{
    public class OkulValidator:AbstractValidator<Okul>
    {
        public OkulValidator()
        {

            RuleFor(c => c.OkulAdi).Length(1, 150).WithMessage("Okul adı karakter sınırı:[1-150] olmalıdır.").NotEmpty().WithMessage("Okul adı alanı zorunludur");
            RuleFor(c => c.OkulAciklama).Length(1, 5000).WithMessage("Okul açıklama karakter sınırı:[1-5000] olmalıdır.").NotEmpty().WithMessage("Okul açıklama alanı zorunludur");
            RuleFor(c => c.FotoBaglantisi).Length(1, 500).WithMessage("Okul foto bağlantısı karakter sınırı:[1-500] olmalıdır.").NotEmpty().WithMessage("Okul foto bağlantısı alanı zorunludur");
            RuleFor(c => c.OkulPuan).NotEmpty().WithMessage("Okul puanı alanı zorunludur");

        }
    }
}
