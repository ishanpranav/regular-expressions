using System;
using System.Text.RegularExpressions;

namespace DollarRegex;

internal static partial class DollarRegexProgram
{
    [GeneratedRegex(
        @"(\$(-?\d{1,3}(,\d{3})*|\d+)(\.\d+)?\s*(MILLION|BILLION|TRILLION)?(\s*DOLLARS?|USD|US\s*DOLLARS?)?(\s*AND\s*(\d+)\s*CENTS)?)|((-?\d{1,3}(,\d{3})*|\d+)(\.\d+)?\s*(MILLION|BILLION|TRILLION)?(\s*DOLLARS?|USD|US\s*DOLLARS?)(\s*AND\s*(\d+)\s*CENTS)?)",
        RegexOptions.IgnoreCase)]
    private static partial Regex DollarRegex();

    private static void Main()
    {
        string? line;
        Regex regex = DollarRegex();

        while ((line = Console.ReadLine()) != null)
        {
            foreach (Match match in regex.Matches(line))
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
