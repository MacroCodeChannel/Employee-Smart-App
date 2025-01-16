using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesAPP.Converters
{
    public class ValidationResultToHasErrorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            // If the value is not a ValidationResult or the parameter is null
            if (value is not ValidationResult validationResult || parameter == null)
            {
                return null;
            }

            if (validationResult.IsValid)
            {
                return false;
            }

            var property = parameter as string;

            // Check if there is at least one error for the specified property
            return validationResult.Errors.Any(x => x.PropertyName == property);
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
