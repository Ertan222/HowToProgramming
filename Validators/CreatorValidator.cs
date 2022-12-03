using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Helpers;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class CreatorValidator : AbstractValidator<Creator>
    {
        public CreatorValidator() {
            RuleFor(c => c.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is empty, please write your name")
            .MinimumLength(2).MaximumLength(60).WithMessage("{PropertyName} needs to be between 2 - 60 character");
            

            RuleFor(c => c.GenderId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is empty, please choose your gender")
            .LessThan(99).GreaterThanOrEqualTo(1).WithMessage("Please select a valid {PropertyName}");

            RuleFor(c => c.LanguageId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is empty, please choose your language")
            .LessThan(99).GreaterThanOrEqualTo(1).WithMessage("Please select a valid {PropertyName}");


            RuleFor(c => c.FrameworkId)
            .Cascade(CascadeMode.Stop)
            .NotEmpty().WithMessage("{PropertyName} is empty, please choose a framework")
            .LessThan(200).GreaterThanOrEqualTo(1).WithMessage("Please select valid {PropertyNaame}");


        }

    }
}