using DotnetYuzuncuYilProjesi.Core.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetYuzuncuYilProjesi.Service.Validations
{
    public class PlayListDtoValidator:AbstractValidator<PlayListDto>
    {
        public PlayListDtoValidator()
        {
            RuleFor(x=> x.PlaylistName).NotNull().WithMessage("{PropertyName} null geçilemez.").NotEmpty().WithMessage("{PropertyName} boş geçilemez.");

        }
    }
}
