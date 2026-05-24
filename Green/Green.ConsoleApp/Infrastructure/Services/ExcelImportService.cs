using System.Data;
using System.Globalization;
using System.Text;
using ExcelDataReader;
using Green.ConsoleApp.Application.Interfaces;
using Green.ConsoleApp.Domain.Models;
using Green.ConsoleApp.Domain.Validations;

namespace Green.ConsoleApp.Infrastructure.Services;

internal class ExcelImportService : IExcelImporter
{
    public LotteryHistory ImportLotofacilHistory(string filePath)
    {
        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"Arquivo não encontrado: {filePath}");
        }

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        using var stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
        using var reader = ExcelReaderFactory.CreateReader(stream);

        var dataSet = reader.AsDataSet(new ExcelDataSetConfiguration
        {
            ConfigureDataTable = _ => new ExcelDataTableConfiguration
            {
                UseHeaderRow = true
            }
        });

        if (dataSet.Tables.Count == 0)
        {
            throw new InvalidOperationException("Nenhuma planilha encontrada no arquivo.");
        }

        var table = dataSet.Tables[0];
        var draws = ReadDrawsFromTable(table);

        return new LotteryHistory
        {
            Lottery = "Lotofacil",
            LastImportDate = DateOnly.FromDateTime(DateTime.Today),
            Draws = draws
        };
    }

    private static List<LotteryDraw> ReadDrawsFromTable(DataTable table)
    {
        var contestColumn = FindColumnByHeader(table, new[] { "concurso" });
        var drawDateColumn = FindColumnByHeader(table, new[] { "data" });
        var numberColumns = FindNumberColumns(table);

        if (contestColumn is null)
        {
            throw new InvalidOperationException("Não foi possível identificar a coluna de concurso na planilha.");
        }

        if (drawDateColumn is null)
        {
            throw new InvalidOperationException("Não foi possível identificar a coluna de data na planilha.");
        }

        if (numberColumns.Count != 15)
        {
            throw new InvalidOperationException("Não foi possível identificar exatamente 15 colunas de dezenas na planilha.");
        }

        var draws = new List<LotteryDraw>();

        foreach (DataRow row in table.Rows)
        {
            var contestNumber = ParseContestNumber(row[contestColumn]);
            var drawDate = ParseDrawDate(row[drawDateColumn]);

            var numbers = numberColumns
                .Select(column => ParseInteger(row[column]))
                .ToList();

            if (!LotteryValidator.TryNormalizeDrawNumbers(numbers, out var normalizedNumbers, out var errorMessage))
            {
                throw new InvalidOperationException($"Concurso {contestNumber} inválido. {errorMessage}");
            }

            draws.Add(new LotteryDraw
            {
                ContestNumber = contestNumber,
                DrawDate = drawDate,
                Numbers = normalizedNumbers
            });
        }

        return draws.OrderBy(draw => draw.ContestNumber).ToList();
    }

    private static string? FindColumnByHeader(DataTable table, IEnumerable<string> expectedTerms)
    {
        foreach (DataColumn column in table.Columns)
        {
            var header = NormalizeHeader(column.ColumnName);

            if (expectedTerms.Any(term => header.Contains(term, StringComparison.OrdinalIgnoreCase)))
            {
                return column.ColumnName;
            }
        }

        return null;
    }

    private static List<string> FindNumberColumns(DataTable table)
    {
        var numberColumns = new List<string>();

        foreach (DataColumn column in table.Columns)
        {
            var header = NormalizeHeader(column.ColumnName);

            var isNumberColumn =
                header.Contains("bola", StringComparison.OrdinalIgnoreCase) ||
                header.Contains("dezena", StringComparison.OrdinalIgnoreCase) ||
                header.StartsWith("b", StringComparison.OrdinalIgnoreCase);

            if (isNumberColumn)
            {
                numberColumns.Add(column.ColumnName);
            }
        }

        return numberColumns.Take(15).ToList();
    }

    private static string NormalizeHeader(string header)
    {
        return header.Trim().Replace(" ", string.Empty).ToLowerInvariant();
    }

    private static int ParseContestNumber(object value)
    {
        var parsedValue = ParseInteger(value);

        if (parsedValue <= 0)
        {
            throw new InvalidOperationException("Número do concurso inválido.");
        }

        return parsedValue;
    }

    private static DateOnly ParseDrawDate(object value)
    {
        if (value is DateTime dateTime)
        {
            return DateOnly.FromDateTime(dateTime);
        }

        var text = value?.ToString()?.Trim();

        if (string.IsNullOrWhiteSpace(text))
        {
            throw new InvalidOperationException("Data do sorteio vazia.");
        }

        var formats = new[] { "dd/MM/yyyy", "d/M/yyyy", "yyyy-MM-dd" };

        if (DateOnly.TryParseExact(text, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out var date))
        {
            return date;
        }

        if (DateOnly.TryParse(text, out date))
        {
            return date;
        }

        throw new InvalidOperationException($"Data do sorteio inválida: {text}");
    }

    private static int ParseInteger(object value)
    {
        if (value is double numberAsDouble)
        {
            return Convert.ToInt32(numberAsDouble);
        }

        if (value is decimal numberAsDecimal)
        {
            return Convert.ToInt32(numberAsDecimal);
        }

        if (value is int numberAsInt)
        {
            return numberAsInt;
        }

        var text = value?.ToString()?.Trim();

        if (string.IsNullOrWhiteSpace(text) || !int.TryParse(text, out var parsedNumber))
        {
            throw new InvalidOperationException($"Valor numérico inválido: {text}");
        }

        return parsedNumber;
    }
}

