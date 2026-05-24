namespace Green.ConsoleApp.Domain.Models;

public class LotteryHistory
{
    public string Lottery { get; set; } = "Lotofacil";
    public DateOnly LastImportDate { get; set; }
    public List<LotteryDraw> Draws { get; set; } = new();
}
