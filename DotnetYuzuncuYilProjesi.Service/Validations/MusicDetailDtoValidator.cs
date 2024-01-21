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
            RuleFor(x => x.Lyrics).NotEmpty().WithMessage("Şarkı sözleri boş geçilemez!")
             .NotNull().WithMessage("Şarkı sözleri null olamaz!");

            RuleFor(x => x.ReleaseYear).NotEmpty().WithMessage("Şarkı sözleri boş geçilemez!")
                    .NotNull().WithMessage("Şarkı çıkış yılı null olamaz!");
                   
        }
     
    }
}
