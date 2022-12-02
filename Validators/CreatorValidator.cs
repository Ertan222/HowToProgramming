using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using HowToProgramming.Models;

namespace HowToProgramming.Validators
{
    public class CreatorValidator : AbstractValidator<Creator>
    {
        public CreatorValidator() {
            RuleFor()
        }
    }
}