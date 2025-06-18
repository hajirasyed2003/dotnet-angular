using System;
using System.ComponentModel.DataAnnotations;

namespace BookApp.Utilities
{
    public class NoFutureDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value is DateTime date)
            {
                return date <= DateTime.Now;
            }
            return false;
        }
    }
}
