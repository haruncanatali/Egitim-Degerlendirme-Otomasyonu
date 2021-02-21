using Egitim.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Egitim.Business.FluentValidation
{
    public class OgretmenValidator:AbstractValidator<Ogretmen>
    {
        public OgretmenValidator()
        {
            RuleFor(c=>c.OgretmenAdSoyad).Length(1,61).WithMessage("Öğretmen ad soyad alanı max 61 karakter olmalı.").NotEmpty().WithMessage("Öğretmen ad soyad alanı boş geçilemez");
            RuleFor(c => c.OgretmenBrans).Length(1, 100).WithMessage("Öğretmen brans alanı max 100 karakter olmalı.").NotEmpty().WithMessage("Öğretmen brans alanı boş geçilemez");
            RuleFor(c => c.OgretmenAciklama).Length(1, 5000).WithMessage("Öğretmen aciklama alanı max 5000 karakter olmalı.").NotEmpty().WithMessage("Öğretmen aciklama alanı boş geçilemez");
            RuleFor(c => c.OgretmenPuan).NotEmpty().WithMessage("OgretmenPuan alanı boş geçilemez");
            RuleFor(c => c.OkulId).NotEmpty().WithMessage("OkulId alanı boş geçilemez");
            RuleFor(c => c.FotoBaglantisi).Length(1, 500).WithMessage("Foto baglantisi alanı max 500 karakter olmalı.").NotEmpty().WithMessage("Foto baglantisi alanı boş geçilemez");
            RuleFor(c => c.OgretmenPozisyon).Length(1, 100).WithMessage("OgretmenPozisyon alanı max 500 karakter olmalı.").NotEmpty().WithMessage("OgretmenPozisyon alanı boş geçilemez");
        }
    }
}
