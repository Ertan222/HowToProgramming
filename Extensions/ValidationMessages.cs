using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace HowToProgramming.Extensions
{
    public static class ValidationMessages
    {
        public static void AddToModelState(this ValidationResult result, ModelStateDictionary modelstate) {
            foreach (var error in result.Errors)
            {
                modelstate.AddModelError(error.PropertyName,error.ErrorMessage);
            }
        }
    }
}