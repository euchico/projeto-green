namespace Green.Model.Lottery;

internal class Result<TPrize>
{
    public int Id { get; set; }
    public string LotteryTag { get; private set; }
    public int Concourse { get; set; }
    public DateTime Date { get; set; }
    public List<TPrize> Prize { get; set; }

    public Result(string lotteryTag)
    {
        LotteryTag = lotteryTag;
    }
}
