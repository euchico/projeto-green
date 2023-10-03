using LotteryData.Model;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace LotteryData;

class LotteryData
{
    static async Task Main(string[] args)
    {
        string apiUrlBase = @"https://loteriascaixa-api.herokuapp.com/api/";
        List<string> lotteryList = new List<string>();

        MainHttpClient client = new MainHttpClient();
        string response = await client.ConnectionAsync();

        JsonProcess json = new();
        lotteryList = json.GetLotteryList(response);
        lotteryList.Sort();

        response = await client.ConnectionAsync(apiUrlBase + "diadesorte");
        var lotteryBase = JsonConvert.DeserializeObject<LotteryResult[]>(response!);

        DatabaseProcess database = new ();
        bool tableStatus = database.UpdateLotteryDatabase(lotteryBase);

        foreach (var result in lotteryBase)
        {
            Console.WriteLine($"#{result.Loteria}: {result.Concurso}");
        }

        Console.ReadKey();

        //foreach(string lottery in lotteryList)
        //{
        //    response = await client.ConnectionAsync(apiUrlBase + lottery);
        //}
    }
}