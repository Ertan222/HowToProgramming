using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class GenderValidator : AbstractValidator<Gender>
    {
        public GenderValidator() {

            RuleFor(g => g.Name)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("{PropertyName} is empty, please write your name")
                    .MinimumLength(2).MaximumLength(60).WithMessage("{PropertyName} needs to be between 2 - 60 character");
        }
    }
}