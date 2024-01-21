using DotnetYuzuncuYilProjesi.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service.Validations
{
    public class SongDtoValidator:AbstractValidator<SongDto>
    {
        public SongDtoValidator()
        {
            RuleFor(x => x.SongName).NotEmpty().WithMessage("Şarkı ismi bilgisi boş geçilemez.")
                .NotNull().WithMessage("Şarkı ismi bilgisi null olamaz!")
                .MaximumLength(50).WithMessage("Şarkı ismi en fazla 50 karakter olabilir.");

            RuleFor(x => x.Singer).NotEmpty().WithMessage("Şarkıcı bilgisi boş geçilemez!")
                .NotNull().WithMessage("Şarkıcı bilgisi null olamaz!")
                .MaximumLength(50).WithMessage("Şarkıcı ismi en fazla 50 karakter olabilir.");
        }
    }
}
