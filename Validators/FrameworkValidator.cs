using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class FrameworkValidator : AbstractValidator<Framework>
    {
        public FrameworkValidator() {
            RuleFor(f => f.Name)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("{PropertyName} is empty, please write your name")
                    .MinimumLength(2).MaximumLength(60).WithMessage("{PropertyName} needs to be between 2 - 60 character");
            
            
            RuleFor(f => f.CreatorId)
                    .NotEmpty().WithMessage(" {PropertName} is empty, Please select a valid creator ")
                    .GreaterThanOrEqualTo(1).LessThan(99).WithMessage("Please select a valid {PropertyName}");
            

        }
    }
}