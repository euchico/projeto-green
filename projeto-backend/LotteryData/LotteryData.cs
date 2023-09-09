using LotteryData.HttpClients;
using System.Net.Http;
using System.Text.Json;

namespace LotteryData;

class LotteryData
{
    static async Task Main(string[] args)
    {
        MainHttpClient client = new MainHttpClient();
        string response = await client.ConnectionAsync();

        Console.WriteLine(response);
    }
}