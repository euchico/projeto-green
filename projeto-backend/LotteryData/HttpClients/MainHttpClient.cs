using System.Text.Json;

namespace LotteryData.HttpClients;

internal class MainHttpClient
{
    public async Task<string> ConnectionAsync()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync("https://loteriascaixa-api.herokuapp.com/api");
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Temos um problema: {ex.Message}");
                return null;
            }
        }
    }
}
