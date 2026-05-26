using Green.ConsoleApp.Domain.Models;

namespace Green.ConsoleApp.Application.Interfaces;

internal interface IExcelImporter
{
    LotteryHistory UpdateLotofacilHistory(string filePath);
}
