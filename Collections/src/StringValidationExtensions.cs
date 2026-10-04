using System.Text.RegularExpressions;

namespace Collections;

public static class StringValidationExtensions
{
    public static bool IsValidEgyptianPhone(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        const string pattern = @"^(?:(?:010|011|012|015)\d{8}|\+20(?:10|11|12|15)\d{8})$";

        return Regex.IsMatch(value, pattern);
    }

    public static bool IsValidEgyptianNationalId(this string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
            return false;

        const string pattern = @"^[23]\d{13}$";

        return Regex.IsMatch(value, pattern);
    }
}