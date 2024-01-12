using DotnetYuzuncuYilProjesi.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service.Validations
{
    public class MusicDetailDtoValidator:AbstractValidator<MusicDetailDto>
    {
        public MusicDetailDtoValidator()
        {
            RuleFor(x => x.Lyrics).NotEmpty().WithMessage("Lütfen şarkının sözlerini giriniz.")
             .NotNull().WithMessage("Şarkı sözleri null geçilemez!");

            RuleFor(x => x.ReleaseYear).NotEmpty().WithMessage("Lütfen şarkının çıkış yılını belirtiniz.")
                    .NotNull().WithMessage("Şarkı çıkış yılı boş geçilemez");
                   
        }
     
    }
}
