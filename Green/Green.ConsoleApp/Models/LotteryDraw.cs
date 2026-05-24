namespace Green.ConsoleApp.Models;

public class LotteryDraw
{
    public int ContestNumber { get; set; }
    public DateOnly DrawDate { get; set; }
    public List<int> Numbers { get; set; } = new();
}
