namespace Green.ConsoleApp.Domain.Models;

public class LotteryDraw
{
    public int ContestNumber { get; set; }
    public DateOnly DrawDate { get; set; }
    public List<int> Numbers { get; set; } = new();
}
