using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class ParadigmValidator : AbstractValidator<Paradigm>
    {
        public ParadigmValidator() {

            RuleFor(p => p.Name)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("{PropertyName} is empty, please write your name")
                    .MinimumLength(2).MaximumLength(60).WithMessage("{PropertyName} needs to be between 2 - 60 character");
            
            RuleFor(p => p.LanguageId)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Please select a language")
                .GreaterThanOrEqualTo(1).LessThan(99).WithMessage("Please select a valid {PropertyName}");
        }
    }
}