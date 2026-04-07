namespace DevOpsLab4.StringExtensions;

public static class StringExtensionMethods
{
    public static bool StartsWithUpperCaseLetter(this string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            return false;
        }

        return char.IsUpper(input[0]);
    }
}
