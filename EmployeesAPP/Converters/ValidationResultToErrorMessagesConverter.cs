using FluentValidation.Results;
using System.Globalization;


namespace EmployeesAPP.Converters
{
    public class ValidationResultToErrorMessagesConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {

            if (value is not ValidationResult result || result.IsValid)
            {
                return null;
            }

            if(parameter == null)
            {
                return null;
            }

            var property = parameter as string;


            //get all the rrro messages for the property
            IEnumerable<string> errormessages = result.Errors.Where(e => e.PropertyName == property)
                .Select(e => e.ErrorMessage);

            //Retun all the errors in single string
            return string.Join(Environment.NewLine, errormessages);

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException("Convert back not implemented for the converter");
        }
    }
}
