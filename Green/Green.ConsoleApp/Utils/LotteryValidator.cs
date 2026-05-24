namespace Green.ConsoleApp.Utils;

public static class LotteryValidator
{
    public static bool TryNormalizeDrawNumbers(IEnumerable<int> numbers, out List<int> normalizedNumbers, out string errorMessage)
    {
        normalizedNumbers = numbers.OrderBy(number => number).ToList();
        errorMessage = string.Empty;

        if (normalizedNumbers.Count != 15)
        {
            errorMessage = "Cada concurso deve conter exatamente 15 dezenas.";
            return false;
        }

        if (normalizedNumbers.Any(number => number is < 1 or > 25))
        {
            errorMessage = "As dezenas devem estar entre 1 e 25.";
            return false;
        }

        if (normalizedNumbers.Distinct().Count() != 15)
        {
            errorMessage = "Não pode haver dezenas repetidas no mesmo concurso.";
            return false;
        }

        return true;
    }
}
