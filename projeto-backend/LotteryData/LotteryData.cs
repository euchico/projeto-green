using MySql.Data.MySqlClient;
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

        try
        {
            string strConnection = "server=localhost;uid=admin;pwd=%iI^#k2s.7PID*cC,Np|;database=lottery";
            var connection = new MySqlConnection(strConnection);
            connection.Open();

            Console.WriteLine("Conexão realizada!");
        }catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        response = await client.ConnectionAsync(apiUrlBase + "diadesorte");

        //foreach(string lottery in lotteryList)
        //{
        //    response = await client.ConnectionAsync(apiUrlBase + lottery);
        //}
    }
}