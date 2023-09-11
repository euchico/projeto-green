using System.Collections.Generic;

namespace LotteryData;

class LotteryData
{
    static async Task Main(string[] args)
    {
        string apiUrlBase = @"https://loteriascaixa-api.herokuapp.com/api";
        List<string> lotteryList = new List<string>();

        MainHttpClient client = new MainHttpClient();
        string response = await client.ConnectionAsync();

        JsonProcess json = new();
        lotteryList = json.GetLotteryList(response);
        lotteryList.Sort();

        foreach(string lottery in lotteryList)
        {
            response = await client.ConnectionAsync();

        }

        Console.WriteLine(lotteryList);
    }
}