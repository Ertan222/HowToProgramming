using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class LanguageValidator : AbstractValidator<Language>
    {
        public LanguageValidator() {

               RuleFor(l => l.Name)
                    .Cascade(CascadeMode.Stop)
                    .NotEmpty().WithMessage("{PropertyName} is empty, please write your name")
                    .MinimumLength(2).MaximumLength(60).WithMessage("{PropertyName} needs to be between 2 - 60 character");
         

                RuleFor(l => l.Description)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertyName} is empty, please write description")
                        .MinimumLength(10).MaximumLength(9999999).WithMessage("{PropertyName} needs to be at least 10 character");

                RuleFor(l => l.FrameworkId)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertName} is empty, Please select a valid framework")
                        .GreaterThanOrEqualTo(1).LessThan(999).WithMessage("{PropertyName} needs to be at least 1 framework");        
                                       
                RuleFor(l => l.TypeeId)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertName} is empty, Please select a valid framework")
                        .GreaterThanOrEqualTo(1).LessThan(999).WithMessage("{PropertyName} needs to be at least 1 framework");        
                                       
                RuleFor(l => l.LanguageLevelId)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertName} is empty, Please select a valid framework")
                        .GreaterThanOrEqualTo(1).LessThan(999).WithMessage("{PropertyName} needs to be at least 1 framework");        
                                       
                RuleFor(l => l.LanguageFamilyId)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertName} is empty, Please select a valid framework")
                        .GreaterThanOrEqualTo(1).LessThan(999).WithMessage("{PropertyName} needs to be at least 1 framework");        
                                       
                RuleFor(l => l.ParadigmId)
                        .Cascade(CascadeMode.Stop)
                        .NotEmpty().WithMessage("{PropertName} is empty, Please select a valid framework")
                        .GreaterThanOrEqualTo(1).LessThan(999).WithMessage("{PropertyName} needs to be at least 1 framework");
        }
    }
}